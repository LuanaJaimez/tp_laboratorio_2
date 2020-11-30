using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Bolsa<T> where T : Producto
    {
        #region Enumerados
        /// <summary>
        /// Enumerado de precio
        /// </summary>
        enum EPrecio { PrecioDePrendas, PrecioDeAccesorios}
        #endregion

        #region Atributos
        private int capacidad;
        private List<T> productos;

        //Se disparar cuando el precio total de las prendas o los productos supere los 100000
        public delegate void EventoPrecioSuperado(object sender, EventArgs e);
        public event EventoPrecioSuperado PrecioSuperado;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de Lectura de la lista de productos
        /// </summary>
        public List<T> Productos
        {
            get
            {
                return this.productos;
            }
        }

        /// <summary>
        /// Propiedad de Lectura del precio de prendas
        /// </summary>
        public double PrecioDePrendas
        {
            get
            {
                return this.ObtenerPrecio(EPrecio.PrecioDePrendas);
            }
        }

        /// <summary>
        /// Propiedad de Lectura del precio de accesorios
        /// </summary>
        public double PrecioDeAccesorios
        {
            get
            {
                return this.ObtenerPrecio(EPrecio.PrecioDeAccesorios);
            }
        }

        /// <summary>
        /// Propiedad de Lectura del precio total
        /// </summary>
        public double PrecioTotal
        {
            get
            {
                double precioTotal = 0;

                foreach(T producto in this.productos)
                {
                    precioTotal += producto.precio;
                }
                return precioTotal;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa lista
        /// </summary>
        private Bolsa()
        {
            this.productos = new List<T>();
        }

        /// <summary>
        /// Constructor define capacidad
        /// </summary>
        /// <param name="capacidad"></param>
        private Bolsa(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga los datos en una cadena
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("\nCapacidad: {0}\n", capacidad);
            retorno.AppendFormat("Total: {0}\n", PrecioTotal);
            retorno.AppendFormat("Precio prendas: {0}\n", PrecioDePrendas);
            retorno.AppendFormat("Precio accesorios: {0}\n", PrecioDeAccesorios);
            retorno.AppendLine("------------------------------");
            retorno.AppendLine("Listado de productos\n");

            foreach (Producto produc in productos)
            {
                retorno.AppendLine(produc.ToString());
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Acumula los precios de las prendas y/o accesorios y devuelve el total
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        private double ObtenerPrecio(EPrecio precio)
        {
            double precioAcumulado = 0;

            foreach (Producto produc in this.productos)
            {
                if (produc is Prenda && precio == EPrecio.PrecioDePrendas)
                {
                    precioAcumulado += (Double)(Prenda)produc;
                }
                else if (produc is Accesorio && precio == EPrecio.PrecioDeAccesorios)
                {
                    precioAcumulado += (Accesorio)produc;
                }
            }
            return precioAcumulado;
        }
        
        #endregion

        #region Operadores
        /// <summary>
        /// Define capacidad 
        /// </summary>
        /// <param name="capacidad"></param>
        public static implicit operator Bolsa<T>(int capacidad)
        {
            return new Bolsa<T>(capacidad);
        }
 
        /// <summary>
        /// Agregar un producto a la bolsa, si la bolsa no esta llena, si no tira una excepcion
        /// </summary>
        /// <param name="b"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Bolsa<T> operator +(Bolsa<T> b, T p)
        {
            if (b.capacidad > b.productos.Count)
            {
                try
                {
                    b.productos.Add(p);
                    if(b.PrecioTotal > 100000)
                    {
                        b.PrecioSuperado(b, new EventArgs());
                    }
                }
                catch
                {
                    throw new BolsaLlenaException();
                }
            }

            return b;
        }
        #endregion
    }
}
