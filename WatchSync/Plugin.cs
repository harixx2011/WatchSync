using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using WatchSync.Configuration;

namespace WatchSync;

class Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : BasePlugin<PluginConfiguration>(applicationPaths, xmlSerializer)
{
    public override string Name => "WatchSync";
    public override string Description => "Sync watch state between users.";
}
