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
                if (TIC.DatoPersonasDAO.existeCedula(this.txtCedula.Text))
                {
                    MessageBox.Show("Esa cedula ya existe en la BDD...");
                    return; //Abandonar
                }
                x = TIC.DatoPersonasDAO.creacion(personas);
                if (x > 0)
                    MessageBox.Show("Registro Agregado..");
                else
                    MessageBox.Show("No se pudo Agregar el Registro");
            }
            catch (Exception ex)
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
        private void button1_Click(object sender, EventArgs e)
        {
            int y;
            if (this.txtBorrarRegistro.Text == "")
            {
                this.txtBorrarRegistro.Focus();
            }
            else
            {
                try
                {
                    if (TIC.DatoPersonasDAO.existeCedula(this.txtBorrarRegistro.Text))
                    {
                        y = TIC.DatoPersonasDAO.delete(this.txtBorrarRegistro.Text);
                        if(y > 0)
                        {
                            MessageBox.Show("El Registro ha sido Borrado con Exito...");
                            return;
                        }
                        else
                            MessageBox.Show("No se Pudo Borrar Correctamente el Registro en la BDD...");
                    }
                    else
                    {
                        MessageBox.Show("La Cedula Ingresada no esta Almacenada en la BDD...");
                        this.txtBorrarRegistro.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.cargarGridPersonas();
                }  
            }
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}