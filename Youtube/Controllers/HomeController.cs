using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Youtube.Models;
using Youtube.Services;

namespace Youtube.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIntegraYouTube _youtubeService;

        public HomeController(IIntegraYouTube youtubeService)
        {
            _youtubeService = youtubeService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Pesquisar(string q)
        {

            var listaYoutube = _youtubeService.BuscarNoYouTubeAsync(q).Result;

            return Json(listaYoutube);
        }

        public IActionResult Detalhes(TypeItem tipo, string YoutubeId)
        {
            var item = _youtubeService.BuscarNoYouTubePorIDAsync(tipo, YoutubeId).Result;
            return View(item);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
