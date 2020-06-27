using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mgranja.api2
{
    /// <summary>
    /// Serviço de acesso à API de Juros
    /// </summary>
    public class JurosService : IJurosService
    {

        private readonly IConfiguration _config;
        private readonly CultureInfo ci = new CultureInfo("pt-br");

        /// <summary>
        /// Inicialize o serviço de juros, recebe a configuração da aplicação
        /// </summary>
        /// <param name="config"></param>
        public JurosService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Pega a taxa de juros atual da API relacionada
        /// </summary>
        /// <returns>A taxa de juros ao mes atual da aplicacao</returns>
        public double GetJuros()
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();

                string baseURL = _config.GetSection("JurosAPI:BaseURL").Value;

                HttpResponseMessage response = client.GetAsync(baseURL).Result;
                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                return double.Parse(conteudo, ci);

            }
        }
    }
}
