using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Bolsa
    {
        #region Atributos
        private int capacidad;
        private List<Producto> productos;
        #endregion

        #region Propiedades
        public double PrecioDePrendas
        {
            get
            {
                return this.ObtenerPrecio(EPrecio.PrecioDePrendas);
            }
        }

        public double PrecioDeAccesorios
        {
            get
            {
                return this.ObtenerPrecio(EPrecio.PrecioDeAccesorios);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EPrecio.PrecioTotal);
            }
        }
        #endregion

        #region Constructores
        private Bolsa()
        {
            this.productos = new List<Producto>();
        }

        private Bolsa(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Bolsa b)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("\nCapacidad: {0}\n", b.capacidad);
            retorno.AppendFormat("Total por prendas: {0}\n", b.PrecioDePrendas);
            retorno.AppendFormat("Total por accesarios: {0}\n", b.PrecioDeAccesorios);
            retorno.AppendFormat("Total: {0}\n", b.PrecioTotal);
            retorno.AppendLine("**********************************************");
            retorno.AppendLine("Listado de productos");
            retorno.AppendLine("**********************************************");

            foreach (Producto produc in b.productos)
            {
                retorno.AppendLine(produc.ToString());
            }

            return retorno.ToString();
        }

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
                else if (precio == EPrecio.PrecioTotal)
                {
                    if (produc is Prenda)
                    {
                        precioAcumulado += (Double)(Prenda)produc;
                    }
                    else if (produc is Accesorio)
                    {
                        precioAcumulado += (Accesorio)produc;
                    }
                }
            }
            return precioAcumulado;
        }
        
        #endregion

        #region Operadores
        public static implicit operator Bolsa(int capacidad)
        {
            return new Bolsa(capacidad);
        }

        public static bool operator ==(Bolsa b, Producto p)
        {
            bool retorno = false;

            foreach (Producto item in b.productos)
            {
                if (p.Equals(item))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Bolsa b, Producto p)
        {
            return !(b == p);
        }

        public static Bolsa operator +(Bolsa b, Producto p)
        {
            if (b == p)
            {
                Console.WriteLine("El producto ya esta en la bolsa!\n");
            }
            else if (b.capacidad > b.productos.Count)
            {
                b.productos.Add(p);
            }
            else if (b.productos.Count == b.capacidad)
            {
                throw new BolsaLlenaException();
            }

            return b;
        }
        #endregion
    }
}
