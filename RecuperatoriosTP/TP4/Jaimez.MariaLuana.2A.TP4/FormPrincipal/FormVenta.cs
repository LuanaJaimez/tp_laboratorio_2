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
using System.Data.SqlClient;

namespace FormPrincipal
{
    public partial class FormVenta : Form
    {
        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            ListarPrendas.DataSource = prendas.MostrarPrendas();
            ListarAccesorios.DataSource = accesorios.MostrarAccesorios();
        }

        /* Delay para generar boleta
        Thread.Sleep(4000);
        MessageBox("Generando boleta..."); 
        System.Threading.Thread.Sleep(8000);
        MessageBox("Boleta generada!"); */

    }
}
