using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Accesorio : Producto
    {
        #region Enumerados
        public enum ETipoAc
        {
            Reloj, Pulsera, Collar
        }
        public enum ETipoMaterial
        {
            Plata, Oro, Acero
        }
        #endregion

        #region Atributo
        public int idAccesorio;
        public ETipoAc tipo;
        public ETipoMaterial material;
        #endregion

        #region Constructores
        public Accesorio(int id, ETipoAc tipo, ETipoMaterial material, string marca, float precio)
            : base(id, marca, precio)
        {
            this.idAccesorio = id;
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return obj is Accesorio && (Accesorio)obj == this;
        }
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(((string)(this)));
            retorno.AppendFormat("Tipo: {0}\n", this.tipo.ToString());
            retorno.AppendFormat("Material: {0}\n", this.material.ToString());

            return retorno.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Accesorio a1, Accesorio a2)
        {
            return a1.tipo == a2.tipo;
        }

        public static bool operator !=(Accesorio a1, Accesorio a2)
        {
            return !(a1 == a2);
        }

        public static implicit operator Single(Accesorio a)
        {
            return a.precio;
        }
        #endregion
    }
}
