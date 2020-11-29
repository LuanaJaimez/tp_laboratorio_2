namespace FormPrincipal
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TipoP = new System.Windows.Forms.ComboBox();
            this.MarcaP = new System.Windows.Forms.TextBox();
            this.AgregarP = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.PrecioP = new System.Windows.Forms.TextBox();
            this.CaracteristicasP = new System.Windows.Forms.GroupBox();
            this.CantidadP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CantidadA = new System.Windows.Forms.TextBox();
            this.MaterialA = new System.Windows.Forms.ComboBox();
            this.PrecioA = new System.Windows.Forms.TextBox();
            this.MarcaA = new System.Windows.Forms.TextBox();
            this.TipoA = new System.Windows.Forms.ComboBox();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CaracteristicasP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoP
            // 
            this.TipoP.BackColor = System.Drawing.SystemColors.Info;
            this.TipoP.FormattingEnabled = true;
            this.TipoP.Items.AddRange(new object[] {
            "Remera",
            "Pantalon",
            "Zapato"});
            this.TipoP.Location = new System.Drawing.Point(16, 31);
            this.TipoP.Name = "TipoP";
            this.TipoP.Size = new System.Drawing.Size(156, 21);
            this.TipoP.TabIndex = 0;
            this.TipoP.Text = "Elija Tipo";
            // 
            // MarcaP
            // 
            this.MarcaP.BackColor = System.Drawing.SystemColors.Info;
            this.MarcaP.Location = new System.Drawing.Point(237, 32);
            this.MarcaP.Name = "MarcaP";
            this.MarcaP.Size = new System.Drawing.Size(117, 20);
            this.MarcaP.TabIndex = 1;
            this.MarcaP.Text = "Ingrese Marca";
            // 
            // AgregarP
            // 
            this.AgregarP.AutoSize = true;
            this.AgregarP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarP.Location = new System.Drawing.Point(12, 9);
            this.AgregarP.Name = "AgregarP";
            this.AgregarP.Size = new System.Drawing.Size(158, 23);
            this.AgregarP.TabIndex = 2;
            this.AgregarP.Text = "Agregar Producto";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Location = new System.Drawing.Point(565, 62);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(129, 58);
            this.btnAgregarP.TabIndex = 3;
            this.btnAgregarP.Text = "Agregar prenda a la lista";
            this.btnAgregarP.UseVisualStyleBackColor = false;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Location = new System.Drawing.Point(5, 62);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // PrecioP
            // 
            this.PrecioP.BackColor = System.Drawing.SystemColors.Info;
            this.PrecioP.Location = new System.Drawing.Point(16, 83);
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.Size = new System.Drawing.Size(117, 20);
            this.PrecioP.TabIndex = 5;
            this.PrecioP.Text = "Ingrese Precio";
            this.PrecioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioP_KeyPress);
            // 
            // CaracteristicasP
            // 
            this.CaracteristicasP.Controls.Add(this.CantidadP);
            this.CaracteristicasP.Controls.Add(this.PrecioP);
            this.CaracteristicasP.Controls.Add(this.MarcaP);
            this.CaracteristicasP.Controls.Add(this.TipoP);
            this.CaracteristicasP.Location = new System.Drawing.Point(24, 52);
            this.CaracteristicasP.Name = "CaracteristicasP";
            this.CaracteristicasP.Size = new System.Drawing.Size(519, 123);
            this.CaracteristicasP.TabIndex = 6;
            this.CaracteristicasP.TabStop = false;
            this.CaracteristicasP.Text = "Caracteristicas de la Prenda";
            // 
            // CantidadP
            // 
            this.CantidadP.BackColor = System.Drawing.SystemColors.Info;
            this.CantidadP.Location = new System.Drawing.Point(237, 83);
            this.CantidadP.Name = "CantidadP";
            this.CantidadP.Size = new System.Drawing.Size(117, 20);
            this.CantidadP.TabIndex = 6;
            this.CantidadP.Text = "Ingrese Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CantidadA);
            this.groupBox1.Controls.Add(this.MaterialA);
            this.groupBox1.Controls.Add(this.PrecioA);
            this.groupBox1.Controls.Add(this.MarcaA);
            this.groupBox1.Controls.Add(this.TipoA);
            this.groupBox1.Location = new System.Drawing.Point(24, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas del Accesorio";
            // 
            // CantidadA
            // 
            this.CantidadA.BackColor = System.Drawing.SystemColors.Info;
            this.CantidadA.Location = new System.Drawing.Point(396, 32);
            this.CantidadA.Name = "CantidadA";
            this.CantidadA.Size = new System.Drawing.Size(117, 20);
            this.CantidadA.TabIndex = 7;
            this.CantidadA.Text = "Ingrese Cantidad";
            // 
            // MaterialA
            // 
            this.MaterialA.BackColor = System.Drawing.SystemColors.Info;
            this.MaterialA.FormattingEnabled = true;
            this.MaterialA.Items.AddRange(new object[] {
            "Acero",
            "Plata",
            "Oro"});
            this.MaterialA.Location = new System.Drawing.Point(237, 84);
            this.MaterialA.Name = "MaterialA";
            this.MaterialA.Size = new System.Drawing.Size(150, 21);
            this.MaterialA.TabIndex = 6;
            this.MaterialA.Text = "Elija Material";
            // 
            // PrecioA
            // 
            this.PrecioA.BackColor = System.Drawing.SystemColors.Info;
            this.PrecioA.Location = new System.Drawing.Point(16, 85);
            this.PrecioA.Name = "PrecioA";
            this.PrecioA.Size = new System.Drawing.Size(117, 20);
            this.PrecioA.TabIndex = 5;
            this.PrecioA.Text = "Ingrese Precio";
            // 
            // MarcaA
            // 
            this.MarcaA.BackColor = System.Drawing.SystemColors.Info;
            this.MarcaA.Location = new System.Drawing.Point(237, 32);
            this.MarcaA.Name = "MarcaA";
            this.MarcaA.Size = new System.Drawing.Size(117, 20);
            this.MarcaA.TabIndex = 1;
            this.MarcaA.Text = "Ingrese Marca";
            // 
            // TipoA
            // 
            this.TipoA.BackColor = System.Drawing.SystemColors.Info;
            this.TipoA.FormattingEnabled = true;
            this.TipoA.Items.AddRange(new object[] {
            "Collar",
            "Pulsera",
            "Reloj"});
            this.TipoA.Location = new System.Drawing.Point(16, 31);
            this.TipoA.Name = "TipoA";
            this.TipoA.Size = new System.Drawing.Size(172, 21);
            this.TipoA.TabIndex = 0;
            this.TipoA.Text = "Elija Tipo";
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarA.Location = new System.Drawing.Point(565, 312);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(129, 59);
            this.btnAgregarA.TabIndex = 8;
            this.btnAgregarA.Text = "Agregar accesorio a la lista";
            this.btnAgregarA.UseVisualStyleBackColor = false;
            this.btnAgregarA.Click += new System.EventHandler(this.btnAgregarA_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVolver.Location = new System.Drawing.Point(5, 16);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 40);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCerrar.Location = new System.Drawing.Point(5, 108);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 40);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Location = new System.Drawing.Point(601, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 154);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(739, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregarA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CaracteristicasP);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.AgregarP);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrenda_FormClosing);
            this.CaracteristicasP.ResumeLayout(false);
            this.CaracteristicasP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoP;
        private System.Windows.Forms.TextBox MarcaP;
        private System.Windows.Forms.Label AgregarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox PrecioP;
        private System.Windows.Forms.GroupBox CaracteristicasP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PrecioA;
        private System.Windows.Forms.TextBox MarcaA;
        private System.Windows.Forms.ComboBox TipoA;
        private System.Windows.Forms.Button btnAgregarA;
        private System.Windows.Forms.ComboBox MaterialA;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox CantidadP;
        private System.Windows.Forms.TextBox CantidadA;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}