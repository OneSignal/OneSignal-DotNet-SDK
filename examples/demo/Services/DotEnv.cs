namespace OneSignalDemo.Services;

public static class DotEnv
{
    private static readonly Dictionary<string, string> _values = new();
    private static bool _loaded;

    public static void Load()
    {
        if (_loaded)
            return;

        try
        {
            using var stream = FileSystem
                .OpenAppPackageFileAsync(".env")
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            using var reader = new StreamReader(stream);
            var content = reader.ReadToEnd();

            foreach (var line in content.Split('\n', StringSplitOptions.RemoveEmptyEntries))
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
                    value = value[1..^1];

                _values[key] = value;
            }
        }
        catch (Exception)
        {
            // .env file not bundled or unreadable -- keys will remain empty
        }
        finally
        {
            _loaded = true;
        }
    }

    public static string Get(string key) => _values.TryGetValue(key, out var value) ? value : "";
}
