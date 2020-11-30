using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo
{
    public interface ISerializar
    {
        bool Xml();

        string Path
        {
            get;
        }
    }
}
