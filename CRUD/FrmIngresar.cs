using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FrmIngresar : Form
    {
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void FrmIngresar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TIC.DatosPersonas personas = new TIC.DatosPersonas();
            personas.Cedula = txtCedula.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Nombres = txtNombres.Text;
            personas.Sexo = cmbSexo.Text;
            personas.FechaNacimineto = dtFechaNacimineto.Value;
            personas.Correo = txtCorreo.Text;
            personas.Estatura = int.Parse(txtEstatura.Text);
            personas.Peso = int.Parse(txtPeso.Text);
            int x = TIC.DatoPersonasDAO.creacion(personas);
            if (x > 0)

                MessageBox.Show("Registro Agregado..");

            else
                MessageBox.Show("No se pudo agregar el registro");

        }
    }
}
