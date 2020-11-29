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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void AgregarP_Click(object sender, EventArgs e)
        {
            FormProducto frmPrenda = new FormProducto();

            this.Hide();

            frmPrenda.Show();
        }

        private void EliminarP_Click(object sender, EventArgs e)
        {
            FormEliminar frmEliminarProduc = new FormEliminar();

            this.Hide();

            frmEliminarProduc.Show();
        }

        private void ModificarP_Click(object sender, EventArgs e)
        {
            FormModificar frmModificarProduc = new FormModificar();

            this.Hide();

            frmModificarProduc.Show();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            FormVenta frmVentaProduc = new FormVenta();

            this.Hide();

            frmVentaProduc.Show();
        }
    }
}
