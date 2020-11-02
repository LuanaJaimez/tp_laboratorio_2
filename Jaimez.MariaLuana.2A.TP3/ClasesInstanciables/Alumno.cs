using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase sellada Alumno que deriva de Universitario
    /// </summary>
    public sealed class Alumno : Universitario
    {
        #region Enumerados
        /// <summary>
        /// Estados de cuenta
        /// </summary>
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        #endregion

        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno()
        {
        }


        /// <summary>
        /// Inicializa Alumno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma, EEstadoCuenta.Deudor)
        {

        }


        /// <summary>
        /// Inicializa Alumno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra nombre, apellido, nacionalidad, legajo, estado de la cuenta y clase que toma el alumno.
        /// </summary>
        /// <returns>Cadena con el nombre y el apellido, la nacionalidad de la persona, el legajo, el estado de cuenta y la clase que toma el alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());

            string cuenta = "";

            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    cuenta = "Cuota Al Dia";
                    break;
                case EEstadoCuenta.Deudor:
                    cuenta = "Deudor";
                    break;
                case EEstadoCuenta.Becado:
                    cuenta = "Becado";
                    break;
            }
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", cuenta);
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }


        /// <summary>
        /// Crea una cadena para guardar la clase tomada por el alumno
        /// </summary>
        /// <returns>Cadena con la clase que toma el alumno</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TOMA CLASES DE {0}", this.claseQueToma);

            return sb.ToString();
        }


        /// <summary>
        /// Cadena con nombre, apellido, nacionalidad, legajo, estado de la cuenta y clase que toma el alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
        }


        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        #endregion
    }
}
