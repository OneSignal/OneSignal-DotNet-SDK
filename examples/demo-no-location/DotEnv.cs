namespace OneSignalDemoNoLocation;

public static class DotEnv
{
    private static readonly Dictionary<string, string> Values = new();
    private static bool _loaded;

    public static void Load()
    {
        if (_loaded)
            return;

        try
        {
            using var stream = Task.Run(() => FileSystem.OpenAppPackageFileAsync("appenv"))
                .GetAwaiter()
                .GetResult();
            using var reader = new StreamReader(stream);

            foreach (
                var line in reader.ReadToEnd().Split('\n', StringSplitOptions.RemoveEmptyEntries)
            )
            {
                var trimmed = line.Trim();
                if (trimmed.StartsWith('#') || !trimmed.Contains('='))
                    continue;

                var eqIndex = trimmed.IndexOf('=');
                var key = trimmed[..eqIndex].Trim();
                var value = trimmed[(eqIndex + 1)..].Trim();

                if (
                    value.Length >= 2
                    && (
                        (value[0] == '"' && value[^1] == '"')
                        || (value[0] == '\'' && value[^1] == '\'')
                    )
                )
                {
                    value = value[1..^1];
                }

                Values[key] = value;
            }
        }
        catch
        {
            // Missing .env is expected for first-time demo setup.
        }
        finally
        {
            _loaded = true;
        }
    }

    public static string Get(string key) => Values.TryGetValue(key, out var value) ? value : "";
}
