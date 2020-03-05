using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Models;

namespace Youtube.Services
{
    public interface IMinhaPlaylist
    {
        void AddItem(YoutubeResult youtubeResult);

        YoutubeResult BuscaPorId(Guid id);

        Task<List<YoutubeResult>> BuscaMinhaListaAsync();

        void DeleteItem(Guid Id);
    }
}
