using System.Text.Json;

namespace OneSignalDemo.Models;

public class UserData
{
    public Dictionary<string, string> Aliases { get; }
    public Dictionary<string, string> Tags { get; }
    public List<string> Emails { get; }
    public List<string> SmsNumbers { get; }
    public string? ExternalId { get; }

    public UserData(
        Dictionary<string, string> aliases,
        Dictionary<string, string> tags,
        List<string> emails,
        List<string> smsNumbers,
        string? externalId)
    {
        Aliases = aliases;
        Tags = tags;
        Emails = emails;
        SmsNumbers = smsNumbers;
        ExternalId = externalId;
    }

    public static UserData? FromJson(JsonElement json)
    {
        try
        {
            var aliases = new Dictionary<string, string>();
            if (json.TryGetProperty("identity", out var identity))
            {
                foreach (var prop in identity.EnumerateObject())
                {
                    if (prop.Name is "external_id" or "onesignal_id") continue;
                    aliases[prop.Name] = prop.Value.GetString() ?? "";
                }
            }

            string? externalId = null;
            if (json.TryGetProperty("identity", out var id2) && id2.TryGetProperty("external_id", out var extId))
                externalId = extId.GetString();

            var tags = new Dictionary<string, string>();
            if (json.TryGetProperty("properties", out var props) && props.TryGetProperty("tags", out var tagsEl))
            {
                foreach (var prop in tagsEl.EnumerateObject())
                    tags[prop.Name] = prop.Value.GetString() ?? "";
            }

            var emails = new List<string>();
            var smsNumbers = new List<string>();
            if (json.TryGetProperty("subscriptions", out var subs))
            {
                foreach (var sub in subs.EnumerateArray())
                {
                    if (!sub.TryGetProperty("type", out var typeEl)) continue;
                    var subType = typeEl.GetString();
                    var token = sub.TryGetProperty("token", out var tokenEl) ? tokenEl.GetString() : null;
                    if (string.IsNullOrEmpty(token)) continue;

                    if (subType == "Email") emails.Add(token);
                    else if (subType == "SMS") smsNumbers.Add(token);
                }
            }

            return new UserData(aliases, tags, emails, smsNumbers, externalId);
        }
        catch
        {
            return null;
        }
    }
}
