using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace FormPrincipal
{
    public partial class FormVenta : Form
    {
        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();

        static SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");

        public FormVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datagrid con la tabla de prendas y productos cuando arranca el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVenta_Load(object sender, EventArgs e)
        {
            ListarPrendas.DataSource = prendas.MostrarPrendas();
            ListarAccesorios.DataSource = accesorios.MostrarAccesorios();
        }

        /// <summary>
        /// permite el manejo de tipos de prendas
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static Prenda.ETipoPrenda TiposPrendas(string aux)
        {
            switch (aux)
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

        /// <summary>
        /// permite el manejo de tipo de accesorios
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static Accesorio.ETipoAc TiposAc(string aux)
        {
            switch (aux)
            {
                case "Reloj":
                    return Accesorio.ETipoAc.Reloj;
                case "Pulsera":
                    return Accesorio.ETipoAc.Pulsera;
                case "Collar":
                    return Accesorio.ETipoAc.Collar;
                default:
                    return Accesorio.ETipoAc.SinDato;
            }
        }

        /// <summary>
        /// permite el manejo de materiales de accesorios
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static Accesorio.ETipoMaterial MaterialAc(string aux)
        {
            switch(aux)
            {
                case "Acero":
                    return Accesorio.ETipoMaterial.Acero;
                case "Plata":
                    return Accesorio.ETipoMaterial.Plata;
                case "Oro":
                    return Accesorio.ETipoMaterial.Oro;
                default:
                    return Accesorio.ETipoMaterial.SinDato;
            }
        }

        /// <summary>
        /// guarda los datos de la prenda en una lista y esa lista se guarda en un archivo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            List<Prenda> auxPrenda = new List<Prenda>();

            try
            {
                string consultaP = "SELECT * FROM PrendaBD WHERE PID = @PID";

                conexion.Open();

                SqlCommand comandP = new SqlCommand(consultaP, conexion);
                comandP.Parameters.AddWithValue("@PID", tbComprarP.Text);
                comandP.ExecuteNonQuery();
                SqlDataReader infoP = comandP.ExecuteReader();


                while (infoP.Read())
                {
                    auxPrenda.Add(new Prenda(int.Parse(infoP["PID"].ToString()),
                                             TiposPrendas(infoP["Tipo"].ToString()),
                                                infoP["Marca"].ToString(),
                                             int.Parse(infoP["Precio"].ToString()),
                                             int.Parse(infoP["Cantidad"].ToString())));
                }

                try
                {
                    MessageBox.Show("Guardar Boleta como...");
                    System.Threading.Thread.Sleep(2000);

                    if (GuardarArchivo.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(GuardarArchivo.FileName))
                        {
                            string txt = GuardarArchivo.FileName;
                            StreamWriter guardarLista = File.CreateText(txt);
                            foreach (string prenda in auxPrenda)
                            {
                                guardarLista.Write(prenda);
                            }
                            guardarLista.Flush();
                            guardarLista.Close();
                        }
                        else
                        {
                            string txt = GuardarArchivo.FileName;
                            StreamWriter guardarLista = File.CreateText(txt);
                            foreach (string prenda in auxPrenda)
                            {
                                guardarLista.Write(prenda);
                            }
                            guardarLista.Flush();
                            guardarLista.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar");
                }

                MessageBox.Show("Compra Finalizada");
            }
            catch (AccederArchivoException)
            {

            }
            finally
            {
                conexion.Close();
            }

            
        }

        /// <summary>
        /// guarda los datos del accesorio en un lista y esa lista se guarda en un archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprarAc_Click(object sender, EventArgs e)
        {
            List<Accesorio> auxAccesorio = new List<Accesorio>();

            try
            {
                string consultaA = "SELECT * FROM AccesorioBD WHERE AID = @AID";

                conexion.Open();

                SqlCommand comandA = new SqlCommand(consultaA, conexion);
                comandA.Parameters.AddWithValue("@AID", tbComprarA.Text);
                comandA.ExecuteNonQuery();
                SqlDataReader infoA = comandA.ExecuteReader();

                while (infoA.Read())
                {
                    auxAccesorio.Add(new Accesorio(int.Parse(infoA["AID"].ToString()),
                                             TiposAc(infoA["Tipo"].ToString()),
                                             MaterialAc(infoA["Material"].ToString()),
                                                infoA["Marca"].ToString(),
                                             int.Parse(infoA["Precio"].ToString()),
                                             int.Parse(infoA["Cantidad"].ToString())));
                }

                try
                {
                    MessageBox.Show("Guardar Boleta como...");
                    System.Threading.Thread.Sleep(2000);

                    if (GuardarArchivo.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(GuardarArchivo.FileName))
                        {
                            string txt = GuardarArchivo.FileName;
                            StreamWriter guardarLista = File.CreateText(txt);
                            foreach (string ac in auxAccesorio)
                            {
                                guardarLista.Write(ac);
                            }
                            guardarLista.Flush();
                            guardarLista.Close();
                        }
                        else
                        {
                            string txt = GuardarArchivo.FileName;
                            StreamWriter guardarLista = File.CreateText(txt);
                            foreach (string ac in auxAccesorio)
                            {
                                guardarLista.Write(ac);
                            }
                            guardarLista.Flush();
                            guardarLista.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar");
                }

                MessageBox.Show("Compra Finalizada");
            }
            catch (AccederArchivoException)
            {

            }
            finally
            {
                conexion.Close();
            }

        }

        /// <summary>
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
