using Mgranja.api2;
using Mgranja.api2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace api1_tests
{
    public class CalculaJurosControllerTest
    {
        private readonly CalculaJurosController _controller;
        private readonly IJurosService _jurosService;

        public CalculaJurosControllerTest()
        {
            _jurosService = new MockJurosService();
            _controller = new CalculaJurosController(_jurosService);
        }

        [Fact]
        public void ShowMeTheCode_WhenCalled_ReturnsOkResult()
        {
            string valorTeste = "1";
            int numMeses = 1;

            var okResult = _controller.CalculaJuros(valorTeste, numMeses);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void ShowMeTheCode_ValidValuePassed_ReturnsExpectedValue()
        {
            string valorTeste = "100";
            int numMeses = 5;

            var result = _controller.CalculaJuros(valorTeste, numMeses).Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.True((string)result.Value == "105,10");
        }

        [Fact]
        public void ShowMeTheCode_ValueWithCommaPassed_ReturnsExpectedValue()
        {
            string valorTeste = "100,00";
            int numMeses = 5;

            var result = _controller.CalculaJuros(valorTeste, numMeses).Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.True((string)result.Value == "105,10");
        }

        [Fact]
        public void ShowMeTheCode_ValueWithCommaAndPeriodPassed_ReturnsExpectedValue()
        {
            string valorTeste = "1.000,00";
            int numMeses = 5;

            var result = _controller.CalculaJuros(valorTeste, numMeses).Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.True((string)result.Value == "1051,01");
        }

        [Fact]
        public void ShowMeTheCode_InvalidMonthsPassed_ReturnsInvalidParameterResult()
        {
            string valorTeste = "100";
            int numMeses = -1;

            var badResult = _controller.CalculaJuros(valorTeste, numMeses);

            Assert.IsType<BadRequestObjectResult>(badResult.Result);
        }

        [Fact]
        public void ShowMeTheCode_InvalidValorInicialPassed_ReturnsInvalidParameterResult()
        {
            string valorTeste = "abc";
            int numMeses = 5;

            var badResult = _controller.CalculaJuros(valorTeste, numMeses);

            Assert.IsType<BadRequestObjectResult>(badResult.Result);
        }
    }
}
