namespace FormPrincipal
{
    partial class FormInicio
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
            this.Venta = new System.Windows.Forms.Button();
            this.dtAccesorios = new System.Windows.Forms.DataGridView();
            this.AgregarP = new System.Windows.Forms.Button();
            this.dtPrendas = new System.Windows.Forms.DataGridView();
            this.EliminarP = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.CantidadesP = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.MostrarP = new System.Windows.Forms.Button();
            this.MostrarA = new System.Windows.Forms.Button();
            this.ModificarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrendas)).BeginInit();
            this.CantidadesP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.CadetBlue;
            this.Venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.ForeColor = System.Drawing.SystemColors.Info;
            this.Venta.Location = new System.Drawing.Point(851, 55);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(138, 52);
            this.Venta.TabIndex = 1;
            this.Venta.Text = "Realizar Compra";
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // dtAccesorios
            // 
            this.dtAccesorios.AllowUserToAddRows = false;
            this.dtAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAccesorios.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAccesorios.Location = new System.Drawing.Point(425, 135);
            this.dtAccesorios.Name = "dtAccesorios";
            this.dtAccesorios.ReadOnly = true;
            this.dtAccesorios.RowHeadersVisible = false;
            this.dtAccesorios.Size = new System.Drawing.Size(360, 281);
            this.dtAccesorios.TabIndex = 3;
            // 
            // AgregarP
            // 
            this.AgregarP.BackColor = System.Drawing.Color.PowderBlue;
            this.AgregarP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarP.Location = new System.Drawing.Point(12, 25);
            this.AgregarP.Name = "AgregarP";
            this.AgregarP.Size = new System.Drawing.Size(138, 52);
            this.AgregarP.TabIndex = 4;
            this.AgregarP.Text = "Agregar producto";
            this.AgregarP.UseVisualStyleBackColor = false;
            this.AgregarP.Click += new System.EventHandler(this.AgregarP_Click);
            // 
            // dtPrendas
            // 
            this.dtPrendas.AllowUserToAddRows = false;
            this.dtPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPrendas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPrendas.Location = new System.Drawing.Point(37, 135);
            this.dtPrendas.Name = "dtPrendas";
            this.dtPrendas.ReadOnly = true;
            this.dtPrendas.RowHeadersVisible = false;
            this.dtPrendas.Size = new System.Drawing.Size(359, 281);
            this.dtPrendas.TabIndex = 5;
            // 
            // EliminarP
            // 
            this.EliminarP.BackColor = System.Drawing.Color.PowderBlue;
            this.EliminarP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarP.Location = new System.Drawing.Point(12, 180);
            this.EliminarP.Name = "EliminarP";
            this.EliminarP.Size = new System.Drawing.Size(138, 52);
            this.EliminarP.TabIndex = 7;
            this.EliminarP.Text = "Eliminar Producto";
            this.EliminarP.UseVisualStyleBackColor = false;
            this.EliminarP.Click += new System.EventHandler(this.EliminarP_Click);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Teal;
            this.Titulo.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Info;
            this.Titulo.Location = new System.Drawing.Point(12, 21);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(268, 45);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "~Tienda EstiloMio~";
            this.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CantidadesP
            // 
            this.CantidadesP.Controls.Add(this.ModificarP);
            this.CantidadesP.Controls.Add(this.EliminarP);
            this.CantidadesP.Controls.Add(this.AgregarP);
            this.CantidadesP.Location = new System.Drawing.Point(838, 146);
            this.CantidadesP.Name = "CantidadesP";
            this.CantidadesP.Size = new System.Drawing.Size(162, 256);
            this.CantidadesP.TabIndex = 9;
            this.CantidadesP.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(526, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 29);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "~Lista de Accesorios~";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(137, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 29);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "~Lista de Prendas~";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Cerrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.Info;
            this.Cerrar.Location = new System.Drawing.Point(851, 437);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(138, 52);
            this.Cerrar.TabIndex = 12;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // MostrarP
            // 
            this.MostrarP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MostrarP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarP.Location = new System.Drawing.Point(159, 422);
            this.MostrarP.Name = "MostrarP";
            this.MostrarP.Size = new System.Drawing.Size(101, 52);
            this.MostrarP.TabIndex = 13;
            this.MostrarP.Text = "Mostrar Prendas";
            this.MostrarP.UseVisualStyleBackColor = false;
            this.MostrarP.Click += new System.EventHandler(this.MostrarP_Click);
            // 
            // MostrarA
            // 
            this.MostrarA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MostrarA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarA.Location = new System.Drawing.Point(547, 422);
            this.MostrarA.Name = "MostrarA";
            this.MostrarA.Size = new System.Drawing.Size(112, 52);
            this.MostrarA.TabIndex = 14;
            this.MostrarA.Text = "Mostrar Accesorios";
            this.MostrarA.UseVisualStyleBackColor = false;
            this.MostrarA.Click += new System.EventHandler(this.MostrarA_Click);
            // 
            // ModificarP
            // 
            this.ModificarP.BackColor = System.Drawing.Color.PowderBlue;
            this.ModificarP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarP.Location = new System.Drawing.Point(12, 104);
            this.ModificarP.Name = "ModificarP";
            this.ModificarP.Size = new System.Drawing.Size(138, 52);
            this.ModificarP.TabIndex = 8;
            this.ModificarP.Text = "Modificar producto";
            this.ModificarP.UseVisualStyleBackColor = false;
            this.ModificarP.Click += new System.EventHandler(this.ModificarP_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.MostrarA);
            this.Controls.Add(this.MostrarP);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CantidadesP);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dtPrendas);
            this.Controls.Add(this.dtAccesorios);
            this.Controls.Add(this.Venta);
            this.Name = "FormInicio";
            this.Text = "Tienda de Ropa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrendas)).EndInit();
            this.CantidadesP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.DataGridView dtAccesorios;
        private System.Windows.Forms.Button AgregarP;
        private System.Windows.Forms.DataGridView dtPrendas;
        private System.Windows.Forms.Button EliminarP;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.GroupBox CantidadesP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button MostrarP;
        private System.Windows.Forms.Button MostrarA;
        private System.Windows.Forms.Button ModificarP;
    }
}