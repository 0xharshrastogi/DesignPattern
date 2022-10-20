namespace ProxyPattern.Youtube;

public class YoutubeLibrary : IYoutubeService
{
    private static readonly List<YoutubeVideo> YoutubeVideos = new();

    public YoutubeVideo? DownloadVideo(int videoId) => YoutubeVideos.Find(video => video.Id == videoId);

    public YoutubeVideo? GetVideoInfo(int videoId) => YoutubeVideos.Find(video => video.Id == videoId);

    public IEnumerable<YoutubeVideo> ListVideos() => YoutubeVideos.AsEnumerable();
}
