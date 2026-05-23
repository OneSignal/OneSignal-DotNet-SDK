using System.Diagnostics;
using System.Text;
using System.Text.Json;
using OneSignalDemo.Models;

namespace OneSignalDemo.Services;

public class OneSignalApiService
{
    private const string DefaultAndroidChannelId = "b3b015d9-c050-4042-8548-dcc34aa44aa4";

    private string _appId = "";

    public void SetAppId(string appId) => _appId = appId;

    public string GetAppId() => _appId;

    public bool HasApiKey()
    {
        var key = DotEnv.Get("ONESIGNAL_API_KEY");
        return !string.IsNullOrWhiteSpace(key) && key != "your_rest_api_key";
    }

    private string GetApiKey() => DotEnv.Get("ONESIGNAL_API_KEY");

    private static string GetAndroidChannelId()
    {
        var value = DotEnv.Get("ONESIGNAL_ANDROID_CHANNEL_ID")?.Trim();
        return string.IsNullOrEmpty(value) ? DefaultAndroidChannelId : value;
    }

    public async Task<bool> SendNotificationAsync(NotificationType type, string subscriptionId)
    {
        try
        {
            string title,
                body;
            Dictionary<string, object>? extra = null;

            switch (type)
            {
                case NotificationType.Simple:
                    title = "Simple Notification";
                    body = "This is a simple push notification";
                    break;
                case NotificationType.WithImage:
                    title = "Image Notification";
                    body = "This notification includes an image";
                    extra = new Dictionary<string, object>
                    {
                        ["big_picture"] =
                            "https://media.onesignal.com/automated_push_templates/ratings_template.png",
                        ["ios_attachments"] = new Dictionary<string, string>
                        {
                            ["image"] =
                                "https://media.onesignal.com/automated_push_templates/ratings_template.png",
                        },
                        ["mutable_content"] = true,
                    };
                    break;
                case NotificationType.WithSound:
                    title = "Sound Notification";
                    body = "This notification plays a custom sound";
                    extra = new Dictionary<string, object>
                    {
                        ["ios_sound"] = "vine_boom.wav",
                        ["android_channel_id"] = GetAndroidChannelId(),
                    };
                    break;
                default:
                    return false;
            }

            return await SendAsync(title, body, subscriptionId, extra);
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> SendCustomNotificationAsync(
        string title,
        string body,
        string subscriptionId
    )
    {
        try
        {
            return await SendAsync(title, body, subscriptionId, null);
        }
        catch
        {
            return false;
        }
    }

    private async Task<bool> SendAsync(
        string title,
        string body,
        string subscriptionId,
        Dictionary<string, object>? extra
    )
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.onesignal.v1+json");

        var payload = new Dictionary<string, object>
        {
            ["app_id"] = _appId,
            ["headings"] = new Dictionary<string, string> { ["en"] = title },
            ["contents"] = new Dictionary<string, string> { ["en"] = body },
            ["include_subscription_ids"] = new[] { subscriptionId },
        };

        if (extra != null)
        {
            foreach (var kv in extra)
                payload[kv.Key] = kv.Value;
        }

        var json = JsonSerializer.Serialize(payload);

        const int maxAttempts = 5;

        // Retry while the OneSignal backend hasn't yet indexed the freshly
        // created subscription. The /notifications endpoint reports this race
        // in a few different shapes, all of which return HTTP 200:
        //   {"id":"...","recipients":0}                       (user just switched, push token not yet attached)
        //   {"id":"...","errors":{"invalid_player_ids":[...]}}
        //   {"id":"","errors":["All included players are not subscribed"]}
        //   {"id":"","errors":[...]}
        // Treat any 200 response with no real id, populated errors, or recipients=0 as transient.
        for (var attempt = 1; attempt <= maxAttempts; attempt++)
        {
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(
                    "https://onesignal.com/api/v1/notifications",
                    content
                );
                var responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    Debug.WriteLine($"Send notification failed: {responseJson}");
                    return false;
                }

                if (IsTransientSendFailure(responseJson))
                {
                    if (attempt < maxAttempts)
                    {
                        var delayMs = 2000 * (1 << (attempt - 1));
                        await Task.Delay(delayMs);
                        continue;
                    }
                    Debug.WriteLine($"Send notification failed: {responseJson}");
                    return false;
                }

                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine($"Send notification error: {err}");
                return false;
            }
        }

        return false;
    }

    private static bool IsTransientSendFailure(string responseJson)
    {
        if (string.IsNullOrWhiteSpace(responseJson))
            return false;
        try
        {
            using var doc = JsonDocument.Parse(responseJson);
            if (doc.RootElement.ValueKind != JsonValueKind.Object)
                return false;

            var hasErrors = false;
            if (doc.RootElement.TryGetProperty("errors", out var errors))
            {
                if (errors.ValueKind == JsonValueKind.Array)
                {
                    hasErrors = errors.GetArrayLength() > 0;
                }
                else if (errors.ValueKind == JsonValueKind.Object)
                {
                    var props = errors.EnumerateObject();
                    hasErrors = props.MoveNext();
                }
            }

            var missingId = true;
            if (
                doc.RootElement.TryGetProperty("id", out var id)
                && id.ValueKind == JsonValueKind.String
                && !string.IsNullOrEmpty(id.GetString())
            )
            {
                missingId = false;
            }

            var zeroRecipients = false;
            if (
                doc.RootElement.TryGetProperty("recipients", out var recipients)
                && recipients.ValueKind == JsonValueKind.Number
                && recipients.TryGetInt64(out var recipientsCount)
                && recipientsCount == 0
            )
            {
                zeroRecipients = true;
            }

            return hasErrors || missingId || zeroRecipients;
        }
        catch
        {
            return false;
        }
    }

    public async Task<UserData?> FetchUserAsync(string onesignalId)
    {
        try
        {
            using var client = new HttpClient();
            var url =
                $"https://api.onesignal.com/apps/{_appId}/users/by/onesignal_id/{onesignalId}";
            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);
            return UserData.FromJson(doc.RootElement);
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> UpdateLiveActivityAsync(
        string activityId,
        string eventType,
        Dictionary<string, object>? eventUpdates = null
    )
    {
        try
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Key {GetApiKey()}");

            var payload = new Dictionary<string, object>
            {
                ["event"] = eventType,
                ["name"] = "Live Activity Update",
                ["priority"] = 10,
            };

            if (eventType == "end")
            {
                payload["dismissal_date"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                payload["event_updates"] = new Dictionary<string, object>
                {
                    ["data"] =
                        eventUpdates ?? new Dictionary<string, object> { ["message"] = "Ended" },
                };
            }
            else if (eventUpdates != null)
            {
                payload["event_updates"] = new Dictionary<string, object>
                {
                    ["data"] = eventUpdates,
                };
            }

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var url =
                $"https://api.onesignal.com/apps/{_appId}/live_activities/{activityId}/notifications";
            var response = await client.PostAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}
