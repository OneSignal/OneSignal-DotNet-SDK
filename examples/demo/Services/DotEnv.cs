namespace OneSignalDemo.Services;

public static class DotEnv
{
    private static readonly Dictionary<string, string> _values = new();
    private static bool _loaded;

    public static void Load()
    {
        if (_loaded)
            return;

        _loaded = true;

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
                _values[key] = value;
            }
        }
        catch (FileNotFoundException)
        {
            // .env file not bundled -- keys will remain empty
        }
    }

    public static string Get(string key) => _values.TryGetValue(key, out var value) ? value : "";
}
