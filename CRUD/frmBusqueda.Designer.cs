namespace CRUD
{
    partial class frmBusqueda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaNacimineto = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCedula = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaNacimineto);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtEstatura);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtFechaNacimineto
            // 
            this.dtFechaNacimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimineto.Location = new System.Drawing.Point(115, 131);
            this.dtFechaNacimineto.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaNacimineto.Name = "dtFechaNacimineto";
            this.dtFechaNacimineto.Size = new System.Drawing.Size(189, 20);
            this.dtFechaNacimineto.TabIndex = 32;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(39, 104);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(265, 21);
            this.cmbSexo.TabIndex = 31;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(39, 205);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(265, 20);
            this.txtPeso.TabIndex = 30;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(59, 181);
            this.txtEstatura.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstatura.MaxLength = 3;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(246, 20);
            this.txtEstatura.TabIndex = 29;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(47, 157);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 60;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(258, 20);
            this.txtCorreo.TabIndex = 28;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(59, 76);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(245, 20);
            this.txtNombres.TabIndex = 27;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(59, 53);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(245, 20);
            this.txtApellidos.TabIndex = 26;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(51, 27);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(254, 20);
            this.txtCedula.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Estatura ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cedula";
            // 
            // cmbCedula
            // 
            this.cmbCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCedula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCedula.FormattingEnabled = true;
            this.cmbCedula.Location = new System.Drawing.Point(181, 6);
            this.cmbCedula.Name = "cmbCedula";
            this.cmbCedula.Size = new System.Drawing.Size(146, 21);
            this.cmbCedula.TabIndex = 2;
            this.cmbCedula.SelectedIndexChanged += new System.EventHandler(this.cmbCedula_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seleccione a la parsona a buscar";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(13, 275);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 310);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCedula);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBusqueda";
            this.Text = "Busqueda de Personas";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaNacimineto;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargar;
    }
}