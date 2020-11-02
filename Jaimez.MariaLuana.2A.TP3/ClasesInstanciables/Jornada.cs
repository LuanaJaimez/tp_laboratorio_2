using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase publica Jornada
    /// </summary>
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Sobreescribe la lista Alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            { 
                return alumnos; 
            }
            set 
            { 
                this.alumnos = value; 
            }
        }


        /// <summary>
        /// Sobreescribe la Clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get 
            {
                return clase; 
            }
            set
            { 
                this.clase = value; 
            }
        }


        /// <summary>
        /// Sobreescribe la lista de profesores
        /// </summary>
        public Profesor Instructor
        {
            get
            { 
                return instructor; 
            }
            set 
            { 
                this.instructor = value; 
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa la lista de alumnos
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }
 

        /// <summary>
        /// Inicializa Jornada
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda la informacion de jornada en JornadaT.txt
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto archivo = new Texto();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "JornadaT.txt";

            return archivo.Guardar(ruta, jornada.ToString());
        }


        /// <summary>
        /// Lee los datos guardados de JornadaT.txt
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto archivo = new Texto();
            string datos;
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "JornadaT.txt";
            archivo.Leer(ruta, out datos);

            return datos;
        }


        /// <summary>
        /// Crea una cadena que tiene los datos de la jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor);
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno alumno in alumnos)
            {
                sb.AppendFormat(alumno.ToString());
            }
            sb.AppendLine("<------------------------------------------------------------->");

            return sb.ToString();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Universitario alumno in j.alumnos)
            {
                if (alumno.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Una Jornada será distinta a un Alumno si el mismo no participa de la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


        /// <summary>
        /// Agrega un alumno a la clase, validando que no este previamente agregado
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }
        #endregion
    }
}
