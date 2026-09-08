using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using WatchSync.Configuration;

namespace WatchSync;

public class Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : BasePlugin<PluginConfiguration>(applicationPaths, xmlSerializer), IHasWebPages
{
    public override string Name => "WatchSync";
    public override string Description => "Sync watch state between users.";
    public override Guid Id => Guid.Parse("c035a825-eb06-49b4-a962-3703d4acb177");

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return [
            new PluginPageInfo {
                Name = Name,
                DisplayName = "WatchSync Config",
                EnableInMainMenu = true,
                EmbeddedResourcePath = "WatchSync.Configuration.configPage.html"
            }
        ];
    }
}
