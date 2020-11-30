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
    public partial class FormProducto : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        public FormProducto()
        {
            conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
            comando = new SqlCommand();

            InitializeComponent();
        }

        /// <summary>
        /// Agrega una nueva prenda a la tabla de prendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PrendaBD VALUES(@Tipo, @Marca, @Precio, @Cantidad)";

            comando.Parameters.Add(new SqlParameter("Tipo", TipoP.Text));
            comando.Parameters.Add(new SqlParameter("Marca", MarcaP.Text));
            comando.Parameters.Add(new SqlParameter("Precio", PrecioP.Text));
            comando.Parameters.Add(new SqlParameter("Cantidad", CantidadP.Text));

            conexion.Open();

            MessageBox.Show("Prenda Agregada");

            conexion.Close();
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
        /// vuelve al FormInicio
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
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Valida que solo se ingresen numeros
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
        /// Agrega un nuevo accesorio a la tabla de accesorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO AccesorioBD VALUES(@Tipo, @Material, @Marca, @Precio, @Cantidad)";

            comando.Parameters.Add(new SqlParameter("Tipo", TipoA.Text));
            comando.Parameters.Add(new SqlParameter("Material", MaterialA.Text));
            comando.Parameters.Add(new SqlParameter("Marca", MarcaA.Text));
            comando.Parameters.Add(new SqlParameter("Precio", PrecioA.Text));
            comando.Parameters.Add(new SqlParameter("Cantidad", CantidadA.Text));

            conexion.Open();

            MessageBox.Show("Accesorio Agregado");

            conexion.Close();
        }

        /// <summary>
        /// limpia todos los campos de los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.TipoP.Text = "Elija Tipo";
            this.TipoA.Text = "Elija Tipo";
            this.MarcaP.Text = "Ingrese Marca";
            this.MarcaA.Text = "Ingrese Marca";
            this.MaterialA.Text = "Elija Material";
            this.PrecioP.Text = "Ingrese Precio";
            this.PrecioA.Text = "Ingrese Precio";
            this.CantidadP.Text = "Ingrese Cantidad";
            this.CantidadA.Text = "Ingrese Cantidad";
        }
    }
}
