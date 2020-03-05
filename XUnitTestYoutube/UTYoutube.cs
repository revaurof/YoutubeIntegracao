using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Youtube.Controllers;
using Youtube.Services;

namespace XUnitTestYoutube
{
    public class UTYoutube
    {
        HomeController _controller;

        public UTYoutube()
        {
            var mockService = new Mock<IIntegraYouTube>();//Mock
            _controller = new HomeController(mockService.Object);
        }

        [Fact]
        public void PesquisarNoYoutube()
        {
            var result = _controller.Pesquisar("eduardo pires");            
            Assert.IsType<JsonResult>(result);
        }
        [Fact]
        public void DatelhesItemYoutube()
        {
            var result = _controller.Detalhes(Youtube.Models.TypeItem.Video, "");                        
            Assert.IsType<ViewResult>(result);
        }
    }
}
