namespace ProxyPattern.Youtube;

public interface IYoutubeService
{
    IEnumerable<YoutubeVideo> ListVideos();

    YoutubeVideo? GetVideoInfo(int videoId);

    YoutubeVideo? DownloadVideo(int videoId);
}
