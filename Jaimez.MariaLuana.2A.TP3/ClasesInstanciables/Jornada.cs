using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
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

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }
 

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Metodos

        public static bool Guardar(Jornada jornada)
        {
            Texto archivo = new Texto();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Texto.txt";

            return archivo.Guardar(ruta, jornada.ToString());
        }


        public static string Leer()
        {
            Texto archivo = new Texto();

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Texto.txt";
            archivo.Leer(ruta, out string datos);

            return datos;
        }


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


        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


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
