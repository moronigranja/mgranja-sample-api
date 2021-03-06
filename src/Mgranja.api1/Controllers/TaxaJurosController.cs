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
using System.Globalization;

namespace Mgranja.api1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {

        private readonly CultureInfo ci = new CultureInfo("pt-br");
        private readonly double taxaDeJuros = 0.01;

        /// <summary>
        /// retorna a taxa de Juros/mês
        /// </summary>

        /// <response code="200">Retorna a taxa de juros mensal fixa da aplicação  em formato decimal separado por vírgula </response>
        [HttpGet]
        [Route("/MGranja/api1/1.0.0/taxaJuros")]
        [ValidateModelState]
        [SwaggerOperation("TaxaJurosGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Retorna a taxa de juros mensal fixa da aplicação  em formato decimal separado por vírgula ")]
        public virtual ActionResult<string> TaxaJurosGet()
        {
            return Ok(taxaDeJuros.ToString("F2", ci));
        }
    }
}
