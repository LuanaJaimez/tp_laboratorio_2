using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase sellada Profesor que deriva de Universitario
    /// </summary>
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa el atributo random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }


        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {
        }


        /// <summary>
        /// Inicializa Profesor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega dos 2 clases a la cola de clases del profesor.
        /// </summary>
        private void _randomClases()
        {
            int cant = Enum.GetNames(typeof(Universidad.EClases)).Length;

            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)(random.Next(cant)));
            }
        }


        /// <summary>
        /// Muestra las clases del dia del profesor
        /// </summary>
        /// <returns>Cadena con las clases del dia del profesor</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        /// <summary>
        /// Muestra el nombre, el apellido, la nacionalidad, el legajo y las clases del dia del Profesor
        /// </summary>
        /// <returns>Cadena con el nombre, el apellido, la nacionalidad, el legajo y las clases del dia del Profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }


        /// <summary>
        /// Retorna una cadena con el nombre, el apellido, la nacionalidad, el legajo y las clases del dia del Profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }


        /// <summary>
        /// Un Profesor será distinto a un EClase si no da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
