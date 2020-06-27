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
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Mgranja.api2.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ShowCodeController : ControllerBase
    {        

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
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            string exampleJson = null;
            exampleJson = "\"\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}