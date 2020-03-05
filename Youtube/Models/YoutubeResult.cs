using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube.Models
{

    public enum TypeItem
    {
        Channel,
        Video,
        Playlist
    }

    public class YoutubeResult
    {
        [Key]
        public Guid Id { get; set; }
        public string YoutubeId { get; set; }
        //
        // Resumo:
        //     The title of the channel that published the resource that the search result identifies.

        [Display(Name = "Título canal")]
        public string ChannelTitle { get; set; }
        //
        // Resumo:
        //     A description of the search result.

        [Display(Name = "Descrição")]
        public string Description { get; set; }
        //
        // Resumo:
        //     It indicates if the resource (video or channel) has upcoming/active live broadcast
        //     content. Or it's "none" if there is not any upcoming/active live broadcasts.

        public string LiveBroadcastContent { get; set; }
        //
        // Resumo:
        //     The creation date and time of the resource that the search result identifies.
        //     The value is specified in ISO 8601 (YYYY-MM-DDThh:mm:ss.sZ) format.


        public string PublishedAtRaw { get; set; }
        //
        // Resumo:
        //     System.DateTime representation of Google.Apis.YouTube.v3.Data.SearchResultSnippet.PublishedAtRaw.
        [Display(Name = "Publicado em")]
        public DateTime? PublishedAt { get; set; }

        //
        // Resumo:
        //     The title of the search result.

        [Display(Name = "Título")]
        public string Title { get; set; }
        //
        // Resumo:
        //     The ETag of the item.
        public string ETag { get; set; }

        [Display(Name = "Imagem")]
        public string Thumbnails { get; set; }

        [Display(Name = "Tipo")]
        public TypeItem Type { get; set; }
    }
}
