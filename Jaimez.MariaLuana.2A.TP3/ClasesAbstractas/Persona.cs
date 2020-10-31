using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Enumerados
        public enum ENacionalidad { Argentino, Extranjero }
        #endregion

        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
            }
        }


        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = ValidarDni(this.nacionalidad, value);
            }
        }


        public ENacionalidad Nacionalidad
        {
            get
            { 
                return nacionalidad;
            }
            set
            { 
                this.nacionalidad = value;
            }
        }


        public string Nombre
        {
            get
            { 
                return nombre;
            }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.nombre = value;
                }
            }
        }


        public string StringToDNI
        {
            set
            { 
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion


        #region Constructor

        public Persona()
        {
        }


        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }


        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }


        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion


        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("NOMBRE COMPLETO: {0}, {1}\n", this.Apellido, this.Nombre));
            sb.AppendLine(string.Format("NACIONALIDAD: {0}\n", this.Nacionalidad));

            return sb.ToString();
        }


        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && dato > 89999999)
            {
                throw new NacionalidadInvalidaException();
            }
            if (nacionalidad == ENacionalidad.Extranjero && dato < 90000000)
            {
                throw new NacionalidadInvalidaException();
            }
            if (dato < 1 || dato > 99999999)
            {
                throw new DniInvalidoException();
            }
            return dato;
        }


        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

            if (!Int32.TryParse(dato, out int dni))
            {
                throw new DniInvalidoException();
            }
            else
            {
                return ValidarDni(nacionalidad, dni);
            }
        }


        private string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!(char.IsLetter(item) || char.IsWhiteSpace(item)))
                {
                    return null;
                }
            }
            return dato;
        }
        #endregion
    }
}
