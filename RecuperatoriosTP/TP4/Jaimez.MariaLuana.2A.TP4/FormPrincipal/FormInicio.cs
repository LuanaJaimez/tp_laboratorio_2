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
    public partial class FormInicio : Form
    {
        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();

        public FormInicio()
        {
            

            InitializeComponent();
        }

        /// <summary>
        /// carga el datagrid con los datos de la tabla de prendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarP_Click(object sender, EventArgs e)
        {
            try
            {
                dtPrendas.DataSource = prendas.MostrarPrendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// carga el datagrid con los datos de la tabla de accesorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarA_Click(object sender, EventArgs e)
        {
            try
            {
                dtAccesorios.DataSource = accesorios.MostrarAccesorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// pregunta si esta seguro de querer salir, actua en base  a la respuesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// levanta el formulario para agregar un producto a la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarP_Click(object sender, EventArgs e)
        {
            FormProducto frmPrenda = new FormProducto();

            this.Hide();

            frmPrenda.Show();
        }

        /// <summary>
        /// levanta el formularios para eliminar un producto de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EliminarP_Click(object sender, EventArgs e)
        {
            FormEliminar frmEliminarProduc = new FormEliminar();

            this.Hide();

            frmEliminarProduc.Show();
        }

        /// <summary>
        /// levanta el form para modificar un producto de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarP_Click(object sender, EventArgs e)
        {
            FormModificar frmModificarProduc = new FormModificar();

            this.Hide();

            frmModificarProduc.Show();
        }

        /// <summary>
        /// levanta el form para generar una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Venta_Click(object sender, EventArgs e)
        {
            FormVenta frmVentaProduc = new FormVenta();

            this.Hide();

            frmVentaProduc.Show();
        }
    }
}
