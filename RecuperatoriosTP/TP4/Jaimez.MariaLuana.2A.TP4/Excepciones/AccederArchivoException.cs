using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AccederArchivoException : Exception
    {
        public AccederArchivoException(Exception innerException)
            : base("No se puede acceder al archivo", innerException)
        { 

        }
    }
}
