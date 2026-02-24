using System.Text.Json;

namespace OneSignalDemo.Services;

public record TooltipOption(string Name, string Description);
public record TooltipData(string Title, string Description, List<TooltipOption>? Options);

public class TooltipHelper
{
    private static readonly TooltipHelper _instance = new();
    public static TooltipHelper Instance => _instance;

    private Dictionary<string, TooltipData> _tooltips = new();
    private bool _initialized;

    private const string TooltipUrl =
        "https://raw.githubusercontent.com/OneSignal/sdk-shared/main/demo/tooltip_content.json";

    private TooltipHelper() { }

    public async Task InitAsync()
    {
        if (_initialized) return;
        try
        {
            using var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var json = await client.GetStringAsync(TooltipUrl);
            var doc = JsonDocument.Parse(json);
            var result = new Dictionary<string, TooltipData>();

            foreach (var entry in doc.RootElement.EnumerateObject())
            {
                var el = entry.Value;
                var title = el.TryGetProperty("title", out var t) ? t.GetString() ?? "" : "";
                var desc = el.TryGetProperty("description", out var d) ? d.GetString() ?? "" : "";
                List<TooltipOption>? options = null;

                if (el.TryGetProperty("options", out var opts) && opts.ValueKind == JsonValueKind.Array)
                {
                    options = new List<TooltipOption>();
                    foreach (var opt in opts.EnumerateArray())
                    {
                        var name = opt.TryGetProperty("name", out var n) ? n.GetString() ?? "" : "";
                        var optDesc = opt.TryGetProperty("description", out var od) ? od.GetString() ?? "" : "";
                        options.Add(new TooltipOption(name, optDesc));
                    }
                }

                result[entry.Name] = new TooltipData(title, desc, options);
            }

            _tooltips = result;
        }
        catch { }

        _initialized = true;
    }

    public TooltipData? GetTooltip(string key) => _tooltips.GetValueOrDefault(key);
}
