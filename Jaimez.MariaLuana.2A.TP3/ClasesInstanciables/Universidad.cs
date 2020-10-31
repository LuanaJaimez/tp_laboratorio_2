using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Enumerados
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        #endregion

        #region Atributos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesor;
        #endregion

        #region Propiedades

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

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesor = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return MostrarDatos(this);
        }


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


        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> serializador = new Xml<Universidad>();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";
            return serializador.Guardar(ruta, uni);
        }


        public static Universidad Leer()
        {
            Xml<Universidad> deserializador = new Xml<Universidad>();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";
            Universidad retorno;
            deserializador.Leer(ruta, out retorno);

            return retorno;
        }
        #endregion

        #region Operadores

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


        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }


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


        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


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


        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u == a)
            {
                throw new AlumnoRepetidoException();
            }
            u.alumnos.Add(a);
            return u;
        }


        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.profesor.Add(i);
            }
            return u;
        }


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
