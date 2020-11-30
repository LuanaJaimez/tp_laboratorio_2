using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;

namespace FormPrincipal
{
    public partial class FormModificar : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();

        public FormModificar()
        {
            conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
            comando = new SqlCommand();

            InitializeComponent();
        }

        /// <summary>
        /// pregunta si esta seguro de querer salir, actua en base a la respuesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// vuelve al formInicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio frmInicio = new FormInicio();

            this.Hide();

            frmInicio.Show();
        }

        /// <summary>
        /// cierra  el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// valida que solo se ingresen numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrecioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia PRECIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }

        /// <summary>
        /// limpia todos los campos de los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cbMP.Text = "Elija Tipo";
            this.cbMA.Text = "Elija Tipo";
            this.ModifMP.Text = "Ingrese Marca";
            this.ModifMA.Text = "Ingrese Marca";
            this.cbMaterial.Text = "Elija Material";
            this.ModifPP.Text = "Ingrese Precio";
            this.ModifPA.Text = "Ingrese Precio";
            this.ModifCP.Text = "Ingrese Cantidad";
            this.ModifCA.Text = "Ingrese Cantidad";
        }

        /// <summary>
        /// hace el update de la talba con los datos ingresados de la prenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifP_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE PrendaBD SET Tipo = @Tipo, Marca = @Marca, Precio = @Precio, Cantidad = @Cantidad WHERE PID = @PID";
            conexion.Open();
            SqlCommand comand = new SqlCommand(consulta, conexion);
            comand.Parameters.AddWithValue("@Tipo", cbMP.Text);
            comand.Parameters.AddWithValue("@Marca", ModifMP.Text);
            comand.Parameters.AddWithValue("@Precio", ModifPP.Text);
            comand.Parameters.AddWithValue("@Cantidad", ModifCP.Text);
            comand.Parameters.AddWithValue("@PID", tbIDPM.Text);
            comand.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Prenda Actualizada");
        }

        /// <summary>
        /// hace el update de la talba con los datos ingresados del accesorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifA_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE AccesorioBD SET Tipo = @Tipo, Material = @Material, Marca = @Marca, Precio = @Precio, Cantidad = @Cantidad WHERE AID = @AID";
            conexion.Open();
            SqlCommand comand = new SqlCommand(consulta, conexion);
            comand.Parameters.AddWithValue("@Tipo", cbMA.Text);
            comand.Parameters.AddWithValue("@Marca", ModifMA.Text);
            comand.Parameters.AddWithValue("@Precio", ModifPA.Text);
            comand.Parameters.AddWithValue("@Cantidad", ModifCA.Text);
            comand.Parameters.AddWithValue("@AID", tbIDAM.Text);
            comand.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Accesorio Actualizado");
        }

        /// <summary>
        /// carga los datagrid con los datos de las prendas y los accesorios que estan en sus respectivas tablas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModificar_Load(object sender, EventArgs e)
        {
            dgPrendas.DataSource = prendas.MostrarPrendas();
            dgAccesorios.DataSource = accesorios.MostrarAccesorios();
        }
    }
}
