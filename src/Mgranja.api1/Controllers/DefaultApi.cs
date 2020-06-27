/*
 * Taxa de Juros API
 *
 * Retorna a taxa de juros (a.m.) atual da aplicação
 *
 * OpenAPI spec version: 1.0.0
 * Contact: moronigranja@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Mgranja.api1.Attributes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace Mgranja.api1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// retorna a taxa de Juros/mês
        /// </summary>
        
        /// <response code="200">Retorna a taxa de juros mensal fixa da aplicação  em formato decimal separado por vírgula </response>
        [HttpGet]
        [Route("/MGranja/api1/1.0.0/taxaJuros")]
        [ValidateModelState]
        [SwaggerOperation("TaxaJurosGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Retorna a taxa de juros mensal fixa da aplicação  em formato decimal separado por vírgula ")]
        public virtual IActionResult TaxaJurosGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            string exampleJson = null;
            exampleJson = "\"0,01\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
