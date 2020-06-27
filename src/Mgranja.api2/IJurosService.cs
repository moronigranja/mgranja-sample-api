using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mgranja.api2
{
    /// <summary>
    /// Interface para o servico de Juros
    /// </summary>
    public interface IJurosService
    {
        /// <summary>
        /// Deve retornar o valor decimal da taxa de Juros, ou causar uma exceção se o valor não estiver disponível
        /// </summary>
        /// <returns>O valor da taxa de Juros atual</returns>
        double GetJuros();
    }
}
