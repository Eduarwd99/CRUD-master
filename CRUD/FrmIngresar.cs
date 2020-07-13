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
            this.cargarGridPersonas();
        }
        private void cargarGridPersonas()
        {
            DataTable dt = TIC.DatoPersonasDAO.getAll();
            this.dgPersonas.DataSource = dt;
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TIC.DatosPersonas personas = new TIC.DatosPersonas();
            personas.Cedula = txtCedula.Text;
            personas.Apellidos = txtApellidos.Text;
            personas.Nombres = txtNombres.Text;
            if (cmbSexo.Text == "Masculino")
                personas.Sexo = "M";
            else
                personas.Sexo = "F";
            personas.Sexo = cmbSexo.Text;
            personas.FechaNacimiento = dtFechaNacimineto.Value;
            personas.Correo = txtCorreo.Text;
            personas.Estatura = int.Parse(txtEstatura.Text);
            personas.Peso = decimal.Parse(txtPeso.Text);
            int x = 0;
            try
            {
                if(TIC.DatoPersonasDAO.existeCedula(this.txtCedula.Text))
                {
                    MessageBox.Show("Esa cedulaa ya existe en la BDD...");
                    return; //Abandonar
                }
                x = TIC.DatoPersonasDAO.creacion(personas);
                if (x > 0)
                    MessageBox.Show("Registro Agregado..");
                else
                    MessageBox.Show("No se pudo agregar el registro");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                //El codigo que se escribe aqui 
                //Se ejecutra siempre, exista o no un error
                //Por ejemplo cerrar una coneccion: conn.close();
                this.cargarGridPersonas();
            }
        }
    }
}