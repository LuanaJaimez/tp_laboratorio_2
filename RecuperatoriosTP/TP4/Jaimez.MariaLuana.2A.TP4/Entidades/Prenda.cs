using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Prenda : Producto
    {
        #region Enumerados
        public enum ETipoPrenda
        {
            Remera, Pantalon, Zapato, SinDato
        }
        #endregion

        #region Atributos
        public int idProducto;
        public ETipoPrenda tipo;
        #endregion

        #region Constructores
        public Prenda () : base () { }

        public Prenda(int id, ETipoPrenda tipo, string marca, float precio, int cantidad)
            : base(id, marca, precio, cantidad)
        {
            this.idProducto = id;
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(((string)(this)));
            retorno.AppendFormat("Tipo: {0}\n", this.tipo.ToString());

            return retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Prenda && (Prenda)obj == this;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Prenda p1, Prenda p2)
        {
            return p1.tipo == p2.tipo;
        }

        public static bool operator !=(Prenda p1, Prenda p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator Single(Prenda p)
        {
            return p.precio;
        }
        #endregion
    }
}
