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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDventa = new System.Windows.Forms.TextBox();
            this.ListarAccesorios = new System.Windows.Forms.DataGridView();
            this.ListarPrendas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListarAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(639, 433);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(143, 52);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Finalizar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese ID de venta";
            // 
            // tbIDventa
            // 
            this.tbIDventa.Location = new System.Drawing.Point(620, 65);
            this.tbIDventa.Name = "tbIDventa";
            this.tbIDventa.Size = new System.Drawing.Size(185, 20);
            this.tbIDventa.TabIndex = 4;
            // 
            // ListarAccesorios
            // 
            this.ListarAccesorios.AllowUserToAddRows = false;
            this.ListarAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListarAccesorios.BackgroundColor = System.Drawing.Color.MintCream;
            this.ListarAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarAccesorios.Location = new System.Drawing.Point(306, 26);
            this.ListarAccesorios.Name = "ListarAccesorios";
            this.ListarAccesorios.ReadOnly = true;
            this.ListarAccesorios.RowHeadersVisible = false;
            this.ListarAccesorios.Size = new System.Drawing.Size(284, 409);
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
            this.ListarPrendas.Size = new System.Drawing.Size(288, 409);
            this.ListarPrendas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese ID de la PRENDA a comprar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese ID del ACCESORIO a comprar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 10;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 512);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListarPrendas);
            this.Controls.Add(this.ListarAccesorios);
            this.Controls.Add(this.tbIDventa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDventa;
        private System.Windows.Forms.DataGridView ListarAccesorios;
        private System.Windows.Forms.DataGridView ListarPrendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}