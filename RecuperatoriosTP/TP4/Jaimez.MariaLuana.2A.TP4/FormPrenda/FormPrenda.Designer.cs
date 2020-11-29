namespace FormPrenda
{
    partial class FormPrenda
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
            this.PrecioP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipoP
            // 
            this.TipoP.FormattingEnabled = true;
            this.TipoP.Location = new System.Drawing.Point(52, 82);
            this.TipoP.Name = "TipoP";
            this.TipoP.Size = new System.Drawing.Size(156, 21);
            this.TipoP.TabIndex = 0;
            this.TipoP.Text = "Elija tipo";
            // 
            // MarcaP
            // 
            this.MarcaP.Location = new System.Drawing.Point(272, 83);
            this.MarcaP.Name = "MarcaP";
            this.MarcaP.Size = new System.Drawing.Size(117, 20);
            this.MarcaP.TabIndex = 1;
            this.MarcaP.Text = "Ingrese marca";
            // 
            // PrecioP
            // 
            this.PrecioP.AutoSize = true;
            this.PrecioP.Location = new System.Drawing.Point(465, 85);
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.Size = new System.Drawing.Size(37, 13);
            this.PrecioP.TabIndex = 2;
            this.PrecioP.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar prenda a la lista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrecioP);
            this.Controls.Add(this.MarcaP);
            this.Controls.Add(this.TipoP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoP;
        private System.Windows.Forms.TextBox MarcaP;
        private System.Windows.Forms.Label PrecioP;
        private System.Windows.Forms.Button button1;
    }
}

