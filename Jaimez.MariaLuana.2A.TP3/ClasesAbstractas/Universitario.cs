using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta Universitario que deriva de Persona
    /// </summary>
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {
        }


        /// <summary>
        /// Inicializa la clase Universitario
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo abstracto
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();


        /// <summary>
        /// Muestra numero de legajo, nombre completo y nacionalidad de la persona
        /// </summary>
        /// <returns>Cadena con el nombre y apellido de la persona, su nacionalidad y legajo.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendFormat("LEGAJO NUMERO: {0}", this.legajo);

            return sb.ToString();
        }


        /// <summary>
        /// Dos objetos seran iguales si son del tipo Universitario y si el Dni o Legajo son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                if ((this.legajo == ((Universitario)obj).legajo || this.DNI == ((Universitario)obj).DNI))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }


        /// <summary>
        /// Dos Universitario serán distintos si no son del mismo Tipo y su Legajo o DNI son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
