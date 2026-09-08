using MediaBrowser.Model.Plugins;

namespace WatchSync.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    public string Options { get; set; } = "OneOption";
    public int AnInteger { get; set; }
    public bool TrueFalseSetting { get; set; }
    public string AString { get; set; } = string.Empty;
}
