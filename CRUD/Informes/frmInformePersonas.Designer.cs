namespace CRUD.Informes
{
    partial class frmInformePersonas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPersonas = new CRUD.Ds.dsPersonas();
            this.datosPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_PersonaTableAdapter = new CRUD.Ds.dsPersonasTableAdapters.Datos_PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosPersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD.Informes.rptPersonas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(804, 392);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsPersonas
            // 
            this.dsPersonas.DataSetName = "dsPersonas";
            this.dsPersonas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosPersonaBindingSource
            // 
            this.datosPersonaBindingSource.DataMember = "Datos_Persona";
            this.datosPersonaBindingSource.DataSource = this.dsPersonas;
            // 
            // datos_PersonaTableAdapter
            // 
            this.datos_PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformePersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformePersonas";
            this.Text = "Informe Personas";
            this.Load += new System.EventHandler(this.frmInformePersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ds.dsPersonas dsPersonas;
        private System.Windows.Forms.BindingSource datosPersonaBindingSource;
        private Ds.dsPersonasTableAdapters.Datos_PersonaTableAdapter datos_PersonaTableAdapter;
    }
}