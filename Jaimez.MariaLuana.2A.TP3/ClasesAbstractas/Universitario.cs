using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores

        public Universitario()
        {
        }


        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        protected abstract string ParticiparEnClase();


        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return sb.ToString();
        }


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

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }


        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
