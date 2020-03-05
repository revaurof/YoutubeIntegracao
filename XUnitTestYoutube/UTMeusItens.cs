using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Youtube.Controllers;
using Youtube.Services;

namespace XUnitTestYoutube
{
   public class UTMeusItens
    {
        MeusItensController _controller;

        public UTMeusItens()
        {
            var MinhaPlayListService = new Mock<IMinhaPlaylist>();//Mock
            var YouTubeServico = new Mock<IIntegraYouTube>();
            _controller = new MeusItensController(MinhaPlayListService.Object, YouTubeServico.Object);
        }

        [Fact]
        public void DetalhesItem()
        {
            var result = _controller.Detalhes(Guid.NewGuid());
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ListaItens()
        {
            var result = _controller.GetVideos();
            Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public void DeleteItem()
        {
            var result = _controller.DeleteFromVue(Guid.NewGuid());
            Assert.IsType<JsonResult>(result);
        }
    }
}
