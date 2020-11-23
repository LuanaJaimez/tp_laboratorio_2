using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        protected int idVenta;
        protected string marca;
        protected float precio;
        #endregion

        public Producto(int id, string marca, float precio)
        {
            this.idVenta = id;
            this.marca = marca;
            this.precio = precio;
        }

        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Marca: {0}\n", p.marca);
            sb.AppendFormat("Precio: {0}\n", p.precio);

            return sb.ToString();
        }


        public static explicit operator string(Producto p)
        {
            return Producto.Mostrar(p);
        }
    }
}
