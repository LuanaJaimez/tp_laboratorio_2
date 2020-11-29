namespace FormPrincipal
{
    partial class FormEliminar
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
            this.dtMostrarPrendas = new System.Windows.Forms.DataGridView();
            this.EliminarP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDP = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDA = new System.Windows.Forms.TextBox();
            this.EliminarA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtMostrarAccesorios = new System.Windows.Forms.DataGridView();
            this.lbEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarPrendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMostrarPrendas
            // 
            this.dtMostrarPrendas.AllowUserToAddRows = false;
            this.dtMostrarPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMostrarPrendas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtMostrarPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMostrarPrendas.Location = new System.Drawing.Point(12, 58);
            this.dtMostrarPrendas.Name = "dtMostrarPrendas";
            this.dtMostrarPrendas.ReadOnly = true;
            this.dtMostrarPrendas.RowHeadersVisible = false;
            this.dtMostrarPrendas.Size = new System.Drawing.Size(301, 409);
            this.dtMostrarPrendas.TabIndex = 0;
            // 
            // EliminarP
            // 
            this.EliminarP.BackColor = System.Drawing.Color.ForestGreen;
            this.EliminarP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarP.ForeColor = System.Drawing.SystemColors.Info;
            this.EliminarP.Location = new System.Drawing.Point(98, 246);
            this.EliminarP.Name = "EliminarP";
            this.EliminarP.Size = new System.Drawing.Size(161, 48);
            this.EliminarP.TabIndex = 2;
            this.EliminarP.Text = "Eliminar Prenda";
            this.EliminarP.UseVisualStyleBackColor = false;
            this.EliminarP.Click += new System.EventHandler(this.EliminarP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese ID de la PRENDA a eliminar";
            // 
            // tbIDP
            // 
            this.tbIDP.Location = new System.Drawing.Point(63, 71);
            this.tbIDP.Name = "tbIDP";
            this.tbIDP.Size = new System.Drawing.Size(222, 20);
            this.tbIDP.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVolver.Location = new System.Drawing.Point(10, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(161, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(191, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(161, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIDA);
            this.groupBox1.Controls.Add(this.EliminarA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.tbIDP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EliminarP);
            this.groupBox1.Location = new System.Drawing.Point(664, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 472);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbIDA
            // 
            this.tbIDA.Location = new System.Drawing.Point(63, 184);
            this.tbIDA.Name = "tbIDA";
            this.tbIDA.Size = new System.Drawing.Size(222, 20);
            this.tbIDA.TabIndex = 10;
            // 
            // EliminarA
            // 
            this.EliminarA.BackColor = System.Drawing.Color.ForestGreen;
            this.EliminarA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarA.ForeColor = System.Drawing.SystemColors.Info;
            this.EliminarA.Location = new System.Drawing.Point(98, 311);
            this.EliminarA.Name = "EliminarA";
            this.EliminarA.Size = new System.Drawing.Size(161, 48);
            this.EliminarA.TabIndex = 9;
            this.EliminarA.Text = "Eliminar Accesorio";
            this.EliminarA.UseVisualStyleBackColor = false;
            this.EliminarA.Click += new System.EventHandler(this.EliminarA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese ID del ACCESORIO a eliminar";
            // 
            // dtMostrarAccesorios
            // 
            this.dtMostrarAccesorios.AllowUserToAddRows = false;
            this.dtMostrarAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMostrarAccesorios.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtMostrarAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMostrarAccesorios.Location = new System.Drawing.Point(341, 58);
            this.dtMostrarAccesorios.Name = "dtMostrarAccesorios";
            this.dtMostrarAccesorios.ReadOnly = true;
            this.dtMostrarAccesorios.RowHeadersVisible = false;
            this.dtMostrarAccesorios.Size = new System.Drawing.Size(301, 409);
            this.dtMostrarAccesorios.TabIndex = 8;
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminar.Location = new System.Drawing.Point(12, 12);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(165, 23);
            this.lbEliminar.TabIndex = 9;
            this.lbEliminar.Text = "Eliminar Producto";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 496);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.dtMostrarAccesorios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtMostrarPrendas);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEliminar_FormClosing);
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarPrendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarAccesorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMostrarPrendas;
        private System.Windows.Forms.Button EliminarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDP;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtMostrarAccesorios;
        private System.Windows.Forms.Button EliminarA;
        private System.Windows.Forms.TextBox tbIDA;
        private System.Windows.Forms.Label lbEliminar;
    }
}