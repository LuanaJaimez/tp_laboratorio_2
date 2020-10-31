using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Enumerados
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        #endregion

        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores

        public Alumno()
        {
        }


        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;

        }


        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos

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
            sb.AppendFormat("ESTADO CUENTA: {0}\n", cuenta);
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }


        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TOMA CLASES DE {0}\n", this.claseQueToma);

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Operadores

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
        }


        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        #endregion
    }
}
