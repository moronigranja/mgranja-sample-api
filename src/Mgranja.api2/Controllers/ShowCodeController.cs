/*
 * Calcula Juros API
 *
 * Calcula valor final de uma aplicação de Juros por determinado tempo
 *
 * OpenAPI spec version: 1.0.0
 * Contact: moronigranja@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Mgranja.api2.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.Annotations;

namespace Mgranja.api2.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ShowCodeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Construtor padrao do controlador, deve ser injetado o serviço que provê o valor do Juros
        /// </summary>
        /// <param name="configuration"></param>
        public ShowCodeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Retorna a URL do código fonte
        /// </summary>
        /// <remarks>retorna a URL de onde se pode encontrar o código fonte. </remarks>
        /// <response code="200">URL do código fonte</response>
        [HttpGet]
        [Route("/MGranja/api2/1.0.0/showmethecode")]
        [ValidateModelState]
        [SwaggerOperation("ShowMeTheCode")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "URL do código fonte")]
        public virtual ActionResult<string> ShowMeTheCode()
        {
            string SourceURL = _configuration.GetSection("ApplicationSource:URL").Value;
            return Ok(SourceURL);
        }
    }
}
