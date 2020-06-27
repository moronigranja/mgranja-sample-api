using Mgranja.api2.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace api1_tests
{
    public class ShowCodeControllerTest
    {
        private readonly ShowCodeController _controller;
        private readonly IConfiguration _configuration;

        public ShowCodeControllerTest()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            _controller = new ShowCodeController(_configuration);
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
            Assert.True((string)result.Value == _configuration.GetSection("ApplicationSource:URL").Value);
        }
    }
}
