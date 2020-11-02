using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase publica Universidad
    /// </summary>
    public class Universidad
    {
        #region Enumerados
        /// <summary>
        /// Enumerado de clases
        /// </summary>
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        #endregion

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Sobreescribe la lista de alumnos
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
        /// Sobreescribe la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get 
            {
                return profesor; 
            }
            set 
            {
                this.profesor = value;
            }
        }


        /// <summary>
        /// Sobreescribe la lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get 
            {
                return jornada;
            }
            set
            {
                this.jornada = value;
            }
        }


        /// <summary>
        /// sobreescribe items de la lista jornada
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get 
            { 
                return jornada[i]; 
            }
            set 
            { 
                this.jornada[i] = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Inicializa las listas de alumno, profesor y jornada
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesor = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna una cadena con los datos de Universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }


        /// <summary>
        /// Muestras los datos de la Universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Cadena con los datos de Universidad</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            foreach (Jornada jornada in uni.jornada)
            {
                sb.Append(jornada.ToString());
            }

            return sb.ToString();
        }


        /// <summary>
        /// Guardo los datos de Universidad en UniversidadX.xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> serializador = new Xml<Universidad>();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "UniversidadX.xml";
            return serializador.Guardar(ruta, uni);
        }


        /// <summary>
        /// Lee los datos de UniversidadX.xml
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Xml<Universidad> deserializador = new Xml<Universidad>();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "UniversidadX.xml";
            Universidad retorno;
            deserializador.Leer(ruta, out retorno);

            return retorno;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Un Universidad será distinta a un Alumno si el mismo no está inscripto en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }


        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.profesor)
            {
                if (profesor == i)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Un Universidad será distinta a un Profesor si el mismo no está dando clases en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        /// <summary>
        /// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase. Sino, lanzará la Excepción SinProfesorException
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clases)
        {
            foreach (Profesor profesor in u.profesor)
            {
                if (profesor == clases)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }


        /// <summary>
        /// Retornará el primer Profesor que no pueda dar la clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clases)
        {
            foreach (Profesor profesor in u.profesor)
            {
                if (profesor != clases)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }


        /// <summary>
        /// Se suma un alumno a la lista, si no se encuentra en ella. Si al querer agregar alumnos este ya figura en la lista, lanzar la excepción AlumnoRepetidoException
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            
            return u;
        }


        /// <summary>
        /// Se suma un profesor a la lista, si no se encuentra en ella
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.profesor.Add(i);
            }

            return u;
        }


        /// <summary>
        /// Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la
        /// clase, un Profesor que pueda darla(según su atributo ClasesDelDia) y la lista de alumnos que la
        /// toman(todos los que coincidan en su campo ClaseQueToma).
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clases)
        {
            Jornada jornada = new Jornada(clases, g == clases);

            foreach (Alumno alumno in g.alumnos)
            {
                if (alumno == clases)
                {
                    jornada.Alumnos.Add(alumno);
                }
            }
            g.jornada.Add(jornada);

            return g;
        }
        #endregion
    }
}
