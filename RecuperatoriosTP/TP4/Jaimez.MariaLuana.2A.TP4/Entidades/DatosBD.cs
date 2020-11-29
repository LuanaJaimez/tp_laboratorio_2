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

        static SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
        //SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");

        private List<Producto> productos;

        public List<Producto> Productos { get => productos; set => productos = value; }

        public DataTable MostrarPrendas()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM PrendaBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable MostrarAccesorios()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM AccesorioBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }

        /*
        public void DatosConfig()
        {
            SqlDataAdapter datos = new SqlDataAdapter();

            datos.InsertCommand = new SqlCommand("INSERT INTO PrendaBD VALUES (@Tipo, @Marca, @Precio, @Cantidad)", conexion);
            datos.UpdateCommand = new SqlCommand("UPDATE PrendaBD SET Tipo = @Tipo, Marca = @Marca, Precio = @Precio, Cantidad = @Cantidad WHERE ID = @PID", conexion);
            datos.DeleteCommand = new SqlCommand("DELETE FROM clientes WHERE PID = @PID", conexion);

            datos.InsertCommand.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50, "Tipo");
            datos.InsertCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 50, "Marca");
            datos.InsertCommand.Parameters.Add("@Precio", SqlDbType.Float, 20, "Precio");
            datos.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 200, "Cantidad");

            datos.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50, "Tipo");
            datos.UpdateCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 50, "Marca");
            datos.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Float, 20, "Precio");
            datos.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 200, "Cantidad");

            datos.DeleteCommand.Parameters.Add("@PID", SqlDbType.Int, 10, "PID");
        }
        */
       
        public static Prenda.ETipoPrenda MapeoTipo(string aux)
        {
            switch(aux)
            {
                case "Remera":
                    return Prenda.ETipoPrenda.Remera;
                case "Pantalon":
                    return Prenda.ETipoPrenda.Pantalon;
                case "Zapato":
                    return Prenda.ETipoPrenda.Zapato;
                default:
                    return Prenda.ETipoPrenda.SinDato;
            }
        }

        public static List<Prenda> GetPrenda()
        {
            List<Prenda> auxProduc = new List<Prenda>();
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = ("SELECT * FROM PrendaBD");

                conexion.Open();

                SqlDataReader info = comando.ExecuteReader();

                while(info.Read())
                {
                    auxProduc.Add(new Prenda(int.Parse(info["PID"].ToString()),
                                             MapeoTipo(info["Tipo"].ToString()),
                                                info["Marca"].ToString(),
                                             int.Parse(info["Precio"].ToString()),
                                             int.Parse(info["Cantidad"].ToString())));
                }

                return auxProduc;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }


    }
}
