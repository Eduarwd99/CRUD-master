namespace CRUD
{
    partial class FrmModificarMaterias
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNivelMod = new System.Windows.Forms.TextBox();
            this.txtCarreraMod = new System.Windows.Forms.TextBox();
            this.txtCreditosMod = new System.Windows.Forms.TextBox();
            this.txtNombreMateriaMod = new System.Windows.Forms.TextBox();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 24);
            this.button1.TabIndex = 52;
            this.button1.Text = "Cerrar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(14, 146);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 24);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNivelMod
            // 
            this.txtNivelMod.Location = new System.Drawing.Point(46, 113);
            this.txtNivelMod.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivelMod.MaxLength = 2;
            this.txtNivelMod.Name = "txtNivelMod";
            this.txtNivelMod.Size = new System.Drawing.Size(263, 20);
            this.txtNivelMod.TabIndex = 47;
            // 
            // txtCarreraMod
            // 
            this.txtCarreraMod.Location = new System.Drawing.Point(55, 85);
            this.txtCarreraMod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarreraMod.MaxLength = 60;
            this.txtCarreraMod.Name = "txtCarreraMod";
            this.txtCarreraMod.Size = new System.Drawing.Size(254, 20);
            this.txtCarreraMod.TabIndex = 46;
            // 
            // txtCreditosMod
            // 
            this.txtCreditosMod.Location = new System.Drawing.Point(60, 59);
            this.txtCreditosMod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditosMod.MaxLength = 3;
            this.txtCreditosMod.Name = "txtCreditosMod";
            this.txtCreditosMod.Size = new System.Drawing.Size(249, 20);
            this.txtCreditosMod.TabIndex = 45;
            // 
            // txtNombreMateriaMod
            // 
            this.txtNombreMateriaMod.Location = new System.Drawing.Point(90, 32);
            this.txtNombreMateriaMod.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMateriaMod.MaxLength = 60;
            this.txtNombreMateriaMod.Name = "txtNombreMateriaMod";
            this.txtNombreMateriaMod.Size = new System.Drawing.Size(219, 20);
            this.txtNombreMateriaMod.TabIndex = 44;
            // 
            // txtCodigoMod
            // 
            this.txtCodigoMod.Location = new System.Drawing.Point(55, 6);
            this.txtCodigoMod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoMod.MaxLength = 6;
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.ReadOnly = true;
            this.txtCodigoMod.Size = new System.Drawing.Size(254, 20);
            this.txtCodigoMod.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Carrera";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Creditos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "NombreMateria";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Nivel";
            // 
            // FrmModificarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 181);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNivelMod);
            this.Controls.Add(this.txtCarreraMod);
            this.Controls.Add(this.txtCreditosMod);
            this.Controls.Add(this.txtNombreMateriaMod);
            this.Controls.Add(this.txtCodigoMod);
            this.Name = "FrmModificarMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Materias";
            this.Load += new System.EventHandler(this.FrmModificarMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtNivelMod;
        public System.Windows.Forms.TextBox txtCarreraMod;
        public System.Windows.Forms.TextBox txtCreditosMod;
        public System.Windows.Forms.TextBox txtNombreMateriaMod;
        public System.Windows.Forms.TextBox txtCodigoMod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
    }
}