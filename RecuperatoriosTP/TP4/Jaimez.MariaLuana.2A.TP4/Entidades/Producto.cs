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
        public int idVenta;
        public string marca;
        public float precio;
        public int cantidad;
        #endregion

        #region Constructores
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Producto() { }

        /// <summary>
        /// contructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Producto(int id, string marca, float precio, int cantidad)
        {
            this.idVenta = id;
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        #endregion

        /// <summary>
        /// muestra los datos de los productos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Marca: {0}\n", p.marca);
            sb.AppendFormat("Precio: {0}\n", p.precio);
            sb.AppendFormat("Cantidad: {0}\n", p.cantidad);

            return sb.ToString();
        }

        /// <summary>
        /// llama a mostrar 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            return Producto.Mostrar(p);
        }
    }
}
