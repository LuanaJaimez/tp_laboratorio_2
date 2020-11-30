namespace FormPrincipal
{
    partial class FormVenta
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.ListarAccesorios = new System.Windows.Forms.DataGridView();
            this.ListarPrendas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComprarP = new System.Windows.Forms.TextBox();
            this.tbComprarA = new System.Windows.Forms.TextBox();
            this.GuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprarAc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListarAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Teal;
            this.btnComprar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnComprar.Location = new System.Drawing.Point(674, 319);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(143, 52);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Finalizar Compra Prendas";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // ListarAccesorios
            // 
            this.ListarAccesorios.AllowUserToAddRows = false;
            this.ListarAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListarAccesorios.BackgroundColor = System.Drawing.Color.MintCream;
            this.ListarAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarAccesorios.Location = new System.Drawing.Point(323, 26);
            this.ListarAccesorios.Name = "ListarAccesorios";
            this.ListarAccesorios.ReadOnly = true;
            this.ListarAccesorios.RowHeadersVisible = false;
            this.ListarAccesorios.Size = new System.Drawing.Size(300, 409);
            this.ListarAccesorios.TabIndex = 5;
            // 
            // ListarPrendas
            // 
            this.ListarPrendas.AllowUserToAddRows = false;
            this.ListarPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListarPrendas.BackgroundColor = System.Drawing.Color.MintCream;
            this.ListarPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarPrendas.Location = new System.Drawing.Point(12, 26);
            this.ListarPrendas.Name = "ListarPrendas";
            this.ListarPrendas.ReadOnly = true;
            this.ListarPrendas.RowHeadersVisible = false;
            this.ListarPrendas.Size = new System.Drawing.Size(305, 409);
            this.ListarPrendas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese ID de la PRENDA a comprar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese ID del ACCESORIO a comprar";
            // 
            // tbComprarP
            // 
            this.tbComprarP.Location = new System.Drawing.Point(8, 57);
            this.tbComprarP.Name = "tbComprarP";
            this.tbComprarP.Size = new System.Drawing.Size(185, 20);
            this.tbComprarP.TabIndex = 9;
            // 
            // tbComprarA
            // 
            this.tbComprarA.Location = new System.Drawing.Point(8, 160);
            this.tbComprarA.Name = "tbComprarA";
            this.tbComprarA.Size = new System.Drawing.Size(185, 20);
            this.tbComprarA.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbComprarA);
            this.groupBox1.Controls.Add(this.tbComprarP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(640, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 209);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnComprarAc
            // 
            this.btnComprarAc.BackColor = System.Drawing.Color.Teal;
            this.btnComprarAc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarAc.ForeColor = System.Drawing.SystemColors.Info;
            this.btnComprarAc.Location = new System.Drawing.Point(674, 383);
            this.btnComprarAc.Name = "btnComprarAc";
            this.btnComprarAc.Size = new System.Drawing.Size(143, 52);
            this.btnComprarAc.TabIndex = 12;
            this.btnComprarAc.Text = "Finalizar Compra Accesorios";
            this.btnComprarAc.UseVisualStyleBackColor = false;
            this.btnComprarAc.Click += new System.EventHandler(this.btnComprarAc_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(879, 471);
            this.Controls.Add(this.btnComprarAc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListarPrendas);
            this.Controls.Add(this.ListarAccesorios);
            this.Controls.Add(this.btnComprar);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridView ListarAccesorios;
        private System.Windows.Forms.DataGridView ListarPrendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComprarP;
        private System.Windows.Forms.TextBox tbComprarA;
        private System.Windows.Forms.SaveFileDialog GuardarArchivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComprarAc;
    }
}