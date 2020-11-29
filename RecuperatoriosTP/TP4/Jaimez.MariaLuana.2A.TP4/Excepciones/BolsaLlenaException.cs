using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BolsaLlenaException : Exception
    {
        public BolsaLlenaException() : base("No hay mas lugar en la bolsa!\n")
        {

        }
    }
}
