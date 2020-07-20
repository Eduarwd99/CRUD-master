using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC;

namespace CRUD
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            this.cargaComboPersona();
        }
        private void cargaComboPersona()
        {
            DataTable dt = TIC.DatoPersonasDAO.getPersonasEdad();
            this.cmbCedula.DataSource = dt;
            this.cmbCedula.ValueMember = "Cedula";
            this.cmbCedula.DisplayMember = "Nombre";
        }
        private void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cedula = this.cmbCedula.SelectedValue.ToString();
                if (cedula.Length > 0)
                {
                    TIC.DatosPersonas persona = new TIC.DatosPersonas();
                    persona = TIC.DatoPersonasDAO.getPersona(cedula);
                    this.cargarPersona(persona);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cargarPersona(TIC.DatosPersonas persona)
        {
            //Cargar los datos en los txtBox
            this.txtCedula.Text = persona.Cedula;
            this.txtApellidos.Text = persona.Apellidos;
            this.txtNombres.Text = persona.Nombres;
            this.dtFechaNacimineto.Value = persona.FechaNacimiento;
            this.txtEstatura.Text = persona.Estatura.ToString();
            this.txtPeso.Text = persona.Peso.ToString();
            if (persona.Sexo == "M")
                this.cmbSexo.Text = "Masculino";
            else
                this.cmbSexo.Text = "Femenino";
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            String cedula = this.cmbCedula.SelectedValue.ToString();
            TIC.DatosPersonas persona = new TIC.DatosPersonas();
            persona = TIC.DatoPersonasDAO.getPersona(cedula);
            this.cargarPersona(persona);
        }
    }
}
