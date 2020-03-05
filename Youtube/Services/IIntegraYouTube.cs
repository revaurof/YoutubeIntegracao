using System.Collections.Generic;
using System.Threading.Tasks;
using Youtube.Models;

namespace Youtube.Services
{
    public interface IIntegraYouTube
    {
        Task<List<YoutubeResult>> BuscarNoYouTubeAsync(string chavePesquisa);
        
        Task<YoutubeResult> BuscarNoYouTubePorIDAsync(TypeItem tipo, string idYoutube);
    }
}
