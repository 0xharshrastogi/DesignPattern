namespace ProxyPattern.Youtube;

public class CacheYoutubeService : IYoutubeService
{
    private readonly IYoutubeService _youtubeService;
    private readonly IDictionary<int, YoutubeVideo> _cachedDownloadedVideos = new Dictionary<int, YoutubeVideo>();
    private readonly Dictionary<int, YoutubeVideo> _cachedSearchedVideos = new();

    public CacheYoutubeService(IYoutubeService youtubeService)
    {
        _youtubeService = youtubeService;
    }

    public YoutubeVideo? DownloadVideo(int videoId)
    {
        if (_cachedDownloadedVideos.TryGetValue(videoId, out var cachedVideo))
            return cachedVideo;

        var video = _youtubeService.DownloadVideo(videoId);

        if (video is not null)
            _cachedDownloadedVideos[videoId] = video;

        return video;
    }

    public YoutubeVideo? GetVideoInfo(int videoId)
    {
        var video = _cachedSearchedVideos[videoId] ?? _youtubeService.GetVideoInfo(videoId);

        if (video is not null && !_cachedSearchedVideos.ContainsKey(videoId))
            _cachedSearchedVideos[videoId] = video;

        return video;
    }

    public IEnumerable<YoutubeVideo> ListVideos() => _youtubeService.ListVideos();
}
