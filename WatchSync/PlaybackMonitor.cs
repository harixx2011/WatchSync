using Jellyfin.Database.Implementations.Entities.Libraries;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WatchSync;

class PlaybackMonitor(ISessionManager sessionManager, ILogger<PlaybackMonitor> logger) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("WatchSync ist active");
        sessionManager.PlaybackProgress += TrackProgress;
        return Task.CompletedTask;
    }

    public override Task StopAsync(CancellationToken stoppingToken)
    {
        sessionManager.PlaybackProgress -= TrackProgress;
        return Task.CompletedTask;
    }

    private void TrackProgress(object? sender, PlaybackProgressEventArgs playbackProgressEventArgs)
    {
        logger.LogInformation("Playback progress for {media} at {progress} by {user}", playbackProgressEventArgs.MediaSourceId ,playbackProgressEventArgs.PlaybackPositionTicks, playbackProgressEventArgs.ClientName);
    }

}
