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
    public partial class FormEliminar : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();

        public FormEliminar()
        {
            conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
            comando = new SqlCommand();

            InitializeComponent();
        }

        /// <summary>
        /// Muestra las prendas y los accesorios por el datagrid llamando al mostrar de DatosBD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminar_Load(object sender, EventArgs e)
        {
            dtMostrarPrendas.DataSource = prendas.MostrarPrendas();
            dtMostrarAccesorios.DataSource = accesorios.MostrarAccesorios();
        }

        /// <summary>
        /// Vuelve al FormInicio
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
        /// Elimina una prenda elegida por ID de la tabla de prendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EliminarP_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM PrendaBD WHERE PID = @PID";
            conexion.Open();
            SqlCommand comand = new SqlCommand(consulta, conexion);
            comand.Parameters.AddWithValue("@PID", tbIDP.Text);
            comand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Prenda Eliminada");
        }

        /// <summary>
        /// Elimina un accesorio elegido por ID de la tabla de accesorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EliminarA_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM AccesorioBD WHERE AID = @AID";
            conexion.Open();
            SqlCommand comand = new SqlCommand(consulta, conexion);
            comand.Parameters.AddWithValue("@AID", tbIDA.Text);
            comand.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Accesorio Eliminado");
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pregunta si esta seguro de querer salir, actua ante la respuesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
