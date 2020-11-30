using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class DatosBD
    {
        /// <summary>
        /// Conexion con base de datos
        /// </summary>
        static SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");

        /// <summary>
        /// Muestra las prendas de la tabla 
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarPrendas()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM PrendaBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }

        /// <summary>
        /// Muestra los accesorios de la tabla
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarAccesorios()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM AccesorioBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }
    }
}
