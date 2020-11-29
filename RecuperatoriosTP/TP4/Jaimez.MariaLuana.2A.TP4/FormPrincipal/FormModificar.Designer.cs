namespace FormPrincipal
{
    partial class FormModificar
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
            this.cbMP = new System.Windows.Forms.ComboBox();
            this.ModifMP = new System.Windows.Forms.TextBox();
            this.lbModificar = new System.Windows.Forms.Label();
            this.btnModifP = new System.Windows.Forms.Button();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.ModifPP = new System.Windows.Forms.TextBox();
            this.CaracteristicasP = new System.Windows.Forms.GroupBox();
            this.ModifCP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModifCA = new System.Windows.Forms.TextBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.ModifPA = new System.Windows.Forms.TextBox();
            this.ModifMA = new System.Windows.Forms.TextBox();
            this.cbMA = new System.Windows.Forms.ComboBox();
            this.btnModifA = new System.Windows.Forms.Button();
            this.btnVolverI = new System.Windows.Forms.Button();
            this.btnCerrarF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgPrendas = new System.Windows.Forms.DataGridView();
            this.dgAccesorios = new System.Windows.Forms.DataGridView();
            this.tbIDPM = new System.Windows.Forms.TextBox();
            this.tbIDAM = new System.Windows.Forms.TextBox();
            this.CaracteristicasP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMP
            // 
            this.cbMP.BackColor = System.Drawing.SystemColors.Info;
            this.cbMP.FormattingEnabled = true;
            this.cbMP.Items.AddRange(new object[] {
            "Remera",
            "Pantalon",
            "Zapato"});
            this.cbMP.Location = new System.Drawing.Point(16, 85);
            this.cbMP.Name = "cbMP";
            this.cbMP.Size = new System.Drawing.Size(156, 21);
            this.cbMP.TabIndex = 0;
            this.cbMP.Text = "Elija Tipo";
            // 
            // ModifMP
            // 
            this.ModifMP.BackColor = System.Drawing.SystemColors.Info;
            this.ModifMP.Location = new System.Drawing.Point(16, 136);
            this.ModifMP.Name = "ModifMP";
            this.ModifMP.Size = new System.Drawing.Size(117, 20);
            this.ModifMP.TabIndex = 1;
            this.ModifMP.Text = "Ingrese Marca";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Location = new System.Drawing.Point(12, 9);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(175, 23);
            this.lbModificar.TabIndex = 2;
            this.lbModificar.Text = "Modificar Producto";
            // 
            // btnModifP
            // 
            this.btnModifP.BackColor = System.Drawing.Color.LightGreen;
            this.btnModifP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifP.Location = new System.Drawing.Point(619, 341);
            this.btnModifP.Name = "btnModifP";
            this.btnModifP.Size = new System.Drawing.Size(129, 58);
            this.btnModifP.TabIndex = 3;
            this.btnModifP.Text = "Modificar Prenda";
            this.btnModifP.UseVisualStyleBackColor = false;
            this.btnModifP.Click += new System.EventHandler(this.btnModifP_Click);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiarC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarC.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLimpiarC.Location = new System.Drawing.Point(138, 21);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(115, 40);
            this.btnLimpiarC.TabIndex = 4;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = false;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ModifPP
            // 
            this.ModifPP.BackColor = System.Drawing.SystemColors.Info;
            this.ModifPP.Location = new System.Drawing.Point(16, 181);
            this.ModifPP.Name = "ModifPP";
            this.ModifPP.Size = new System.Drawing.Size(117, 20);
            this.ModifPP.TabIndex = 5;
            this.ModifPP.Text = "Ingrese Precio";
            this.ModifPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioP_KeyPress);
            // 
            // CaracteristicasP
            // 
            this.CaracteristicasP.Controls.Add(this.tbIDPM);
            this.CaracteristicasP.Controls.Add(this.ModifCP);
            this.CaracteristicasP.Controls.Add(this.ModifPP);
            this.CaracteristicasP.Controls.Add(this.ModifMP);
            this.CaracteristicasP.Controls.Add(this.cbMP);
            this.CaracteristicasP.Location = new System.Drawing.Point(576, 43);
            this.CaracteristicasP.Name = "CaracteristicasP";
            this.CaracteristicasP.Size = new System.Drawing.Size(199, 279);
            this.CaracteristicasP.TabIndex = 6;
            this.CaracteristicasP.TabStop = false;
            this.CaracteristicasP.Text = "Caracteristicas de la Prenda";
            // 
            // ModifCP
            // 
            this.ModifCP.BackColor = System.Drawing.SystemColors.Info;
            this.ModifCP.Location = new System.Drawing.Point(16, 226);
            this.ModifCP.Name = "ModifCP";
            this.ModifCP.Size = new System.Drawing.Size(117, 20);
            this.ModifCP.TabIndex = 6;
            this.ModifCP.Text = "Ingrese Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIDAM);
            this.groupBox1.Controls.Add(this.ModifCA);
            this.groupBox1.Controls.Add(this.cbMaterial);
            this.groupBox1.Controls.Add(this.ModifPA);
            this.groupBox1.Controls.Add(this.ModifMA);
            this.groupBox1.Controls.Add(this.cbMA);
            this.groupBox1.Location = new System.Drawing.Point(801, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas del Accesorio";
            // 
            // ModifCA
            // 
            this.ModifCA.BackColor = System.Drawing.SystemColors.Info;
            this.ModifCA.Location = new System.Drawing.Point(16, 239);
            this.ModifCA.Name = "ModifCA";
            this.ModifCA.Size = new System.Drawing.Size(117, 20);
            this.ModifCA.TabIndex = 7;
            this.ModifCA.Text = "Ingrese Cantidad";
            // 
            // cbMaterial
            // 
            this.cbMaterial.BackColor = System.Drawing.SystemColors.Info;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Acero",
            "Plata",
            "Oro"});
            this.cbMaterial.Location = new System.Drawing.Point(16, 161);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(150, 21);
            this.cbMaterial.TabIndex = 6;
            this.cbMaterial.Text = "Elija Material";
            // 
            // ModifPA
            // 
            this.ModifPA.BackColor = System.Drawing.SystemColors.Info;
            this.ModifPA.Location = new System.Drawing.Point(16, 199);
            this.ModifPA.Name = "ModifPA";
            this.ModifPA.Size = new System.Drawing.Size(117, 20);
            this.ModifPA.TabIndex = 5;
            this.ModifPA.Text = "Ingrese Precio";
            // 
            // ModifMA
            // 
            this.ModifMA.BackColor = System.Drawing.SystemColors.Info;
            this.ModifMA.Location = new System.Drawing.Point(16, 121);
            this.ModifMA.Name = "ModifMA";
            this.ModifMA.Size = new System.Drawing.Size(117, 20);
            this.ModifMA.TabIndex = 1;
            this.ModifMA.Text = "Ingrese Marca";
            // 
            // cbMA
            // 
            this.cbMA.BackColor = System.Drawing.SystemColors.Info;
            this.cbMA.FormattingEnabled = true;
            this.cbMA.Items.AddRange(new object[] {
            "Collar",
            "Pulsera",
            "Reloj"});
            this.cbMA.Location = new System.Drawing.Point(16, 85);
            this.cbMA.Name = "cbMA";
            this.cbMA.Size = new System.Drawing.Size(172, 21);
            this.cbMA.TabIndex = 0;
            this.cbMA.Text = "Elija Tipo";
            // 
            // btnModifA
            // 
            this.btnModifA.BackColor = System.Drawing.Color.LightGreen;
            this.btnModifA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifA.Location = new System.Drawing.Point(839, 340);
            this.btnModifA.Name = "btnModifA";
            this.btnModifA.Size = new System.Drawing.Size(129, 59);
            this.btnModifA.TabIndex = 8;
            this.btnModifA.Text = "Modificar Accesorio";
            this.btnModifA.UseVisualStyleBackColor = false;
            this.btnModifA.Click += new System.EventHandler(this.btnModifA_Click);
            // 
            // btnVolverI
            // 
            this.btnVolverI.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolverI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverI.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVolverI.Location = new System.Drawing.Point(6, 21);
            this.btnVolverI.Name = "btnVolverI";
            this.btnVolverI.Size = new System.Drawing.Size(115, 40);
            this.btnVolverI.TabIndex = 9;
            this.btnVolverI.Text = "Volver al inicio";
            this.btnVolverI.UseVisualStyleBackColor = false;
            this.btnVolverI.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCerrarF
            // 
            this.btnCerrarF.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCerrarF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarF.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCerrarF.Location = new System.Drawing.Point(269, 21);
            this.btnCerrarF.Name = "btnCerrarF";
            this.btnCerrarF.Size = new System.Drawing.Size(115, 40);
            this.btnCerrarF.TabIndex = 10;
            this.btnCerrarF.Text = "Cerrar";
            this.btnCerrarF.UseVisualStyleBackColor = false;
            this.btnCerrarF.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrarF);
            this.groupBox2.Controls.Add(this.btnVolverI);
            this.groupBox2.Controls.Add(this.btnLimpiarC);
            this.groupBox2.Location = new System.Drawing.Point(592, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgPrendas
            // 
            this.dgPrendas.AllowUserToAddRows = false;
            this.dgPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPrendas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrendas.Location = new System.Drawing.Point(12, 43);
            this.dgPrendas.Name = "dgPrendas";
            this.dgPrendas.ReadOnly = true;
            this.dgPrendas.RowHeadersVisible = false;
            this.dgPrendas.Size = new System.Drawing.Size(261, 449);
            this.dgPrendas.TabIndex = 12;
            // 
            // dgAccesorios
            // 
            this.dgAccesorios.AllowUserToAddRows = false;
            this.dgAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccesorios.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccesorios.Location = new System.Drawing.Point(279, 43);
            this.dgAccesorios.Name = "dgAccesorios";
            this.dgAccesorios.ReadOnly = true;
            this.dgAccesorios.RowHeadersVisible = false;
            this.dgAccesorios.Size = new System.Drawing.Size(285, 449);
            this.dgAccesorios.TabIndex = 13;
            // 
            // tbIDPM
            // 
            this.tbIDPM.BackColor = System.Drawing.SystemColors.Info;
            this.tbIDPM.Location = new System.Drawing.Point(16, 43);
            this.tbIDPM.Name = "tbIDPM";
            this.tbIDPM.Size = new System.Drawing.Size(156, 20);
            this.tbIDPM.TabIndex = 7;
            this.tbIDPM.Text = "Ingrese ID de la PRENDA";
            // 
            // tbIDAM
            // 
            this.tbIDAM.BackColor = System.Drawing.SystemColors.Info;
            this.tbIDAM.Location = new System.Drawing.Point(16, 43);
            this.tbIDAM.Name = "tbIDAM";
            this.tbIDAM.Size = new System.Drawing.Size(156, 20);
            this.tbIDAM.TabIndex = 8;
            this.tbIDAM.Text = "Ingrese ID del ACCESORIO";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1028, 522);
            this.Controls.Add(this.dgAccesorios);
            this.Controls.Add(this.dgPrendas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnModifA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CaracteristicasP);
            this.Controls.Add(this.btnModifP);
            this.Controls.Add(this.lbModificar);
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrenda_FormClosing);
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.CaracteristicasP.ResumeLayout(false);
            this.CaracteristicasP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccesorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMP;
        private System.Windows.Forms.TextBox ModifMP;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Button btnModifP;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.TextBox ModifPP;
        private System.Windows.Forms.GroupBox CaracteristicasP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ModifPA;
        private System.Windows.Forms.TextBox ModifMA;
        private System.Windows.Forms.ComboBox cbMA;
        private System.Windows.Forms.Button btnModifA;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Button btnVolverI;
        private System.Windows.Forms.Button btnCerrarF;
        private System.Windows.Forms.TextBox ModifCP;
        private System.Windows.Forms.TextBox ModifCA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPrendas;
        private System.Windows.Forms.DataGridView dgAccesorios;
        private System.Windows.Forms.TextBox tbIDPM;
        private System.Windows.Forms.TextBox tbIDAM;
    }
}