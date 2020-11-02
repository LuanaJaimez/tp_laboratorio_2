using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta Persona
    /// </summary>
    public abstract class Persona
    {
        #region Enumerados
        /// <summary>
        /// Nacionalidad de las personas
        /// </summary>
        public enum ENacionalidad { Argentino, Extranjero }
        #endregion

        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura de Apellido
        /// </summary>
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


        /// <summary>
        /// Propiedad de lectura y escritura de DNI 
        /// </summary>
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


        /// <summary>
        /// Propiedad de lectura y escritura de Nacionalidad
        /// </summary>
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


        /// <summary>
        /// Propiedad de lectura y escritura de Nombre
        /// </summary>
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


        /// <summary>
        /// Setea DNI. Verifica que el DNI sea valido 
        /// </summary>
        public string StringToDNI
        {
            set
            { 
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {
        }


        /// <summary>
        /// Inicializa la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }


        /// <summary>
        /// Setea el DNI de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }


        /// <summary>
        /// Setea el DNI de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga de metodo ToString
        /// </summary>
        /// <returns>Cadena con el nombre completo y la nacionalidad de la persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre));
            sb.AppendLine(string.Format("NACIONALIDAD: {0}", this.Nacionalidad));

            return sb.ToString();
        }


        /// <summary>
        /// Valida que el DNI sea correcto
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Dato validado</returns>
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


        /// <summary>
        /// Valida que el DNI sea correcto
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Dato validado</returns>
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


        /// <summary>
        /// Valida que la cadena de nombre y apellido este conformada por letras
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
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
