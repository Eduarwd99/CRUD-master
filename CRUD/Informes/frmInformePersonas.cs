using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Informes
{
    public partial class frmInformePersonas : Form
    {
        public frmInformePersonas()
        {
            InitializeComponent();
        }

        private void frmInformePersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPersonas.Datos_Persona' Puede moverla o quitarla según sea necesario.
            this.datos_PersonaTableAdapter.Fill(this.dsPersonas.Datos_Persona);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
