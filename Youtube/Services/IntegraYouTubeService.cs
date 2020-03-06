using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Youtube.Models;

namespace Youtube.Services
{
    public class IntegraYouTubeService : IIntegraYouTube
    {

        public IntegraYouTubeService() { }

        public async Task<List<YoutubeResult>> BuscarNoYouTubeAsync(string chavePesquisa)
        {
            try
            {
                List<YoutubeResult> listaYoutubeItem = new List<YoutubeResult>();

                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = Secrets.YoutubeKey,
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = chavePesquisa;
                searchListRequest.MaxResults = 50;

                // Call the search.list method to retrieve results matching the specified query term.
                var searchListResponse = await searchListRequest.ExecuteAsync();

                YoutubeResult item;
                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            item = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.VideoId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Video
                            };
                            listaYoutubeItem.Add(item);
                            break;

                        case "youtube#channel":
                            item = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.ChannelId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Channel
                            };
                            listaYoutubeItem.Add(item);
                            break;

                        case "youtube#playlist":
                            item = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.PlaylistId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Playlist
                            };
                            listaYoutubeItem.Add(item);
                            break;
                    }
                }

                return listaYoutubeItem;
            }
            catch
            {
                return null;
            }
        }

        public async Task<YoutubeResult> BuscarNoYouTubePorIDAsync(TypeItem tipo, string idYoutube)
        {
            try
            {
                YoutubeResult _youtubeItem = new YoutubeResult();

                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = Secrets.YoutubeKey,
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");

                if (tipo == TypeItem.Video)
                {
                    searchListRequest.Q = idYoutube;
                }
                else if (tipo == TypeItem.Channel)
                {
                    searchListRequest.Type = "channel";
                    searchListRequest.ChannelId = idYoutube;
                }
                else
                {
                    searchListRequest.Q = idYoutube;
                }

                searchListRequest.MaxResults = 50;

                // Call the search.list method to retrieve results matching the specified query term.
                var searchListResponse = await searchListRequest.ExecuteAsync();

                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            _youtubeItem = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.VideoId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Video
                            };
                            break;

                        case "youtube#channel":
                            _youtubeItem = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.ChannelId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Channel
                            };
                            break;

                        case "youtube#playlist":
                            _youtubeItem = new YoutubeResult
                            {
                                YoutubeId = searchResult.Id.PlaylistId,
                                ChannelTitle = searchResult.Snippet.Title,
                                Description = searchResult.Snippet.Description,
                                ETag = searchResult.Snippet.ETag,
                                LiveBroadcastContent = searchResult.Snippet.LiveBroadcastContent,
                                PublishedAt = searchResult.Snippet.PublishedAt,
                                PublishedAtRaw = searchResult.Snippet.PublishedAtRaw,
                                Title = searchResult.Snippet.Title,
                                Thumbnails = searchResult.Snippet.Thumbnails.Medium.Url,
                                Type = TypeItem.Playlist
                            };
                            break;
                    }
                }
                return _youtubeItem;
            }
            catch
            {
                return null;
            }
        }
    }
}
