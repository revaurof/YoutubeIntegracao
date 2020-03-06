using Microsoft.AspNetCore.Mvc;
using System;
using Youtube.Models;
using Youtube.Services;

namespace Youtube.Controllers
{
    public class MeusItensController : Controller
    {
        private readonly IMinhaPlaylist _minhaPlaylist;
        private readonly IIntegraYouTube _youtubeService;
        public MeusItensController(IMinhaPlaylist minhaPlaylist, IIntegraYouTube youtubeService)
        {
            _minhaPlaylist = minhaPlaylist;
            _youtubeService = youtubeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes(Guid id)
        {
            var item = _minhaPlaylist.BuscaPorId(id);
            return View(item);
        }

        public JsonResult AddItem(TypeItem tipo, string YoutubeId)
        {
            var item = _youtubeService.BuscarNoYouTubePorIDAsync(tipo, YoutubeId).Result;
            _minhaPlaylist.AddItem(item);
            return Json(true);
        }

        public JsonResult GetVideos()
        {
            return Json(_minhaPlaylist.BuscaMinhaListaAsync().Result);
        }

        public JsonResult DeleteFromVue(Guid id)
        {
            _minhaPlaylist.DeleteItem(id);
            return Json(true);
        }

    }
}