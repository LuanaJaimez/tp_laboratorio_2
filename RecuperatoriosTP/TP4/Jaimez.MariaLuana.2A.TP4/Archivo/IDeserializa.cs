using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Archivo
{
    public interface IDeserializa
    {
        bool Xml(out Prenda prenda);
    }
}
