using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Data;
using Youtube.Models;

namespace Youtube.Services
{
    public class MinhaPlaylistService : IMinhaPlaylist
    {
        private readonly MeuDbContext _contexto;

        public MinhaPlaylistService(MeuDbContext context)
        {
            _contexto = context;
        }

        public void AddItem(YoutubeResult youtubeResult)
        {
            _contexto.YoutubeResults.Add(youtubeResult);
            _contexto.SaveChanges();
        }

        public YoutubeResult BuscaPorId(Guid id)
        {
            return _contexto.YoutubeResults.FindAsync(id).Result;
        }

        public Task<List<YoutubeResult>> BuscaMinhaListaAsync() => _contexto.YoutubeResults.ToListAsync();

        public void DeleteItem(Guid Id)
        {
            var itemToDelete = _contexto.YoutubeResults.FindAsync(Id).Result;
            _contexto.YoutubeResults.Remove(itemToDelete);
            _contexto.SaveChanges();
        }
    }
}
