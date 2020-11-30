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
            Reloj, Pulsera, Collar, SinDato
        }
        public enum ETipoMaterial
        {
            Plata, Oro, Acero, SinDato
        }
        #endregion

        #region Atributo
        public int idAccesorio;
        public ETipoAc tipo;
        public ETipoMaterial material;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Accesorio () : base () { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipo"></param>
        /// <param name="material"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Accesorio(int id, ETipoAc tipo, ETipoMaterial material, string marca, float precio, int cantidad)
            : base(id, marca, precio, cantidad)
        {
            this.idAccesorio = id;
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Igualdad de accesorios
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Accesorio && (Accesorio)obj == this;
        }

        /// <summary>
        /// Devuelve un string con todos los datos del accesorio
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Dos accesorios seran iguales si son del mismo tipo
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Accesorio a1, Accesorio a2)
        {
            return a1.tipo == a2.tipo;
        }

        /// <summary>
        /// Dos accesorios seran distintos si no son del mismo tipo
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Accesorio a1, Accesorio a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// Precio accesorio
        /// </summary>
        /// <param name="a"></param>
        public static implicit operator Single(Accesorio a)
        {
            return a.precio;
        }
        #endregion
    }
}
