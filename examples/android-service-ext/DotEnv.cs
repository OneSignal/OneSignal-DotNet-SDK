using System.Reflection;

namespace OneSignalAndroidServiceExtension;

internal static class DotEnv
{
    public static string Get(string key)
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("appenv");
        if (stream is null)
            return "";

        using var reader = new StreamReader(stream);
        while (reader.ReadLine() is { } line)
        {
            var trimmed = line.Trim();
            if (trimmed.StartsWith('#'))
                continue;

            var separator = trimmed.IndexOf('=');
            if (separator < 1 || trimmed[..separator].Trim() != key)
                continue;

            return trimmed[(separator + 1)..].Trim().Trim('"', '\'');
        }

        return "";
    }
}
