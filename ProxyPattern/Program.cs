using ProxyPattern.Youtube;

var youtubeLib = new YoutubeLibrary();
IYoutubeService youtubeService = new CacheYoutubeService(youtubeLib);

youtubeService.ListVideos();
