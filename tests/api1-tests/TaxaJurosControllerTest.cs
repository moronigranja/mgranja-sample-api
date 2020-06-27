using Mgranja.api1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace api1_tests
{
    public class TaxaJurosControllerTest
    {
        private readonly TaxaJurosController _controller;

        public TaxaJurosControllerTest()
        {
            _controller = new TaxaJurosController();
        }

        [Fact]
        public void TaxaJurosGet_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.TaxaJurosGet();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void TaxaJurosGet_WhenCalled_ReturnsExpectedValue()
        {
            var okResult = _controller.TaxaJurosGet();
            var result = okResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.True((string)result.Value == "0,01");
        }
    }
}
