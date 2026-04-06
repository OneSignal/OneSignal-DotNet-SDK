using System.Text;
using System.Text.Json;
using OneSignalDemo.Models;

namespace OneSignalDemo.Services;

public class OneSignalApiService
{
    private string _appId = "";

    public void SetAppId(string appId) => _appId = appId;

    public string GetAppId() => _appId;

    public bool HasApiKey()
    {
        var key = DotEnv.Get("ONESIGNAL_API_KEY");
        return !string.IsNullOrWhiteSpace(key) && key != "your_rest_api_key";
    }

    private string GetApiKey() => DotEnv.Get("ONESIGNAL_API_KEY");

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
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(
            "https://onesignal.com/api/v1/notifications",
            content
        );
        return response.IsSuccessStatusCode;
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

            if (eventUpdates != null)
            {
                payload["event_updates"] = new Dictionary<string, object>
                {
                    ["data"] = eventUpdates,
                };
            }

            if (eventType == "end")
            {
                payload["dismissal_date"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                payload["event_updates"] = new Dictionary<string, object>
                {
                    ["data"] =
                        eventUpdates ?? new Dictionary<string, object> { ["message"] = "Ended" },
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
