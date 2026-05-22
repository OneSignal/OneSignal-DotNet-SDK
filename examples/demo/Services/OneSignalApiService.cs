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

        // Retry on `invalid_player_ids` to absorb the brief race where the
        // subscription has been created locally but is not yet visible to the
        // /notifications endpoint.
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

                var invalidIds = GetInvalidPlayerIds(responseJson);
                if (invalidIds.Count > 0)
                {
                    if (attempt < maxAttempts)
                    {
                        var delayMs = 2000 * (1 << (attempt - 1));
                        await Task.Delay(delayMs);
                        continue;
                    }
                    Debug.WriteLine(
                        $"Send notification failed: invalid_player_ids [{string.Join(", ", invalidIds)}]"
                    );
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

    private static List<string> GetInvalidPlayerIds(string responseJson)
    {
        var result = new List<string>();
        if (string.IsNullOrWhiteSpace(responseJson))
            return result;
        try
        {
            using var doc = JsonDocument.Parse(responseJson);
            if (
                doc.RootElement.ValueKind == JsonValueKind.Object
                && doc.RootElement.TryGetProperty("errors", out var errors)
                && errors.ValueKind == JsonValueKind.Object
                && errors.TryGetProperty("invalid_player_ids", out var invalidIds)
                && invalidIds.ValueKind == JsonValueKind.Array
            )
            {
                foreach (var id in invalidIds.EnumerateArray())
                {
                    if (id.ValueKind == JsonValueKind.String)
                    {
                        var s = id.GetString();
                        if (!string.IsNullOrEmpty(s))
                            result.Add(s);
                    }
                }
            }
        }
        catch
        {
            // Ignore malformed bodies; treat as success since status was 2xx.
        }
        return result;
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
