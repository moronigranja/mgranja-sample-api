using Mgranja.api2.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace api1_tests
{
    public class ShowCodeControllerTest
    {
        private readonly ShowCodeController _controller;

        public ShowCodeControllerTest()
        {
            _controller = new ShowCodeController();
        }

        [Fact]
        public void ShowMeTheCode_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.ShowMeTheCode();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void ShowMeTheCode_WhenCalled_ReturnsExpectedValue()
        {
            var okResult = _controller.ShowMeTheCode();
            var result = okResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.True((string)result.Value == "http://www.github.com/mgranja/example");
        }
    }
}
