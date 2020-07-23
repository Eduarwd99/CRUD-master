namespace CRUD
{
    partial class FrmIngresarMaterias
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBorrarRegistro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgMaterias = new System.Windows.Forms.DataGridView();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkModificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 24);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(482, 37);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(77, 24);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBorrarRegistro
            // 
            this.txtBorrarRegistro.Location = new System.Drawing.Point(396, 112);
            this.txtBorrarRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBorrarRegistro.MaxLength = 6;
            this.txtBorrarRegistro.Name = "txtBorrarRegistro";
            this.txtBorrarRegistro.Size = new System.Drawing.Size(163, 20);
            this.txtBorrarRegistro.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Borrar Registro (Ingresar Codigo):";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(482, 65);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(77, 24);
            this.btnBorrar.TabIndex = 47;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgMaterias
            // 
            this.dgMaterias.AllowUserToAddRows = false;
            this.dgMaterias.AllowUserToDeleteRows = false;
            this.dgMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkEliminar,
            this.linkModificar});
            this.dgMaterias.Location = new System.Drawing.Point(11, 148);
            this.dgMaterias.Margin = new System.Windows.Forms.Padding(2);
            this.dgMaterias.Name = "dgMaterias";
            this.dgMaterias.ReadOnly = true;
            this.dgMaterias.RowHeadersWidth = 51;
            this.dgMaterias.RowTemplate.Height = 24;
            this.dgMaterias.Size = new System.Drawing.Size(548, 280);
            this.dgMaterias.TabIndex = 46;
            this.dgMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellContentClick);
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Accion";
            this.linkEliminar.MinimumWidth = 8;
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.ReadOnly = true;
            this.linkEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            this.linkEliminar.Width = 65;
            // 
            // linkModificar
            // 
            this.linkModificar.HeaderText = "Accion";
            this.linkModificar.MinimumWidth = 8;
            this.linkModificar.Name = "linkModificar";
            this.linkModificar.ReadOnly = true;
            this.linkModificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linkModificar.Text = "Modificar";
            this.linkModificar.UseColumnTextForLinkValue = true;
            this.linkModificar.Width = 65;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(399, 65);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(77, 24);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(399, 36);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 24);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(399, 5);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 27);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(43, 113);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.MaxLength = 2;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(339, 20);
            this.txtNivel.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nivel";
            // 
            // txtCarrera
            // 
            this.txtCarrera.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarrera.Location = new System.Drawing.Point(53, 85);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarrera.MaxLength = 60;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(330, 20);
            this.txtCarrera.TabIndex = 67;
            // 
            // txtCreditos
            // 
            this.txtCreditos.BackColor = System.Drawing.SystemColors.Window;
            this.txtCreditos.Location = new System.Drawing.Point(57, 59);
            this.txtCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditos.MaxLength = 3;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(326, 20);
            this.txtCreditos.TabIndex = 62;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreMateria.Location = new System.Drawing.Point(91, 32);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMateria.MaxLength = 60;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(292, 20);
            this.txtNombreMateria.TabIndex = 61;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Location = new System.Drawing.Point(52, 6);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(330, 20);
            this.txtCodigo.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Carrera";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Creditos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "NombreMateria";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Codigo";
            // 
            // FrmIngresarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 439);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtBorrarRegistro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgMaterias);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "FrmIngresarMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Materias";
            this.Load += new System.EventHandler(this.FrmIngresarMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBorrarRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.DataGridView dgMaterias;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
        private System.Windows.Forms.DataGridViewLinkColumn linkModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}