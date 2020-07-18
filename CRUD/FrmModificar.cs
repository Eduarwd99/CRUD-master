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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }
        private void cargarGridPersonasMod()
        {
            //DataTable dt = TIC.DatoPersonasDAO.getAll();
            FrmIngresar FR = new FrmIngresar();
            FR.dgPersonas.DataSource = TIC.DatoPersonasDAO.getAll(); ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int act = 0;
            TIC.DatosPersonas personas = new TIC.DatosPersonas();
            if (this.txtCorreoMod.Text == "" || this.txtApellidosMod.Text == "" || this.txtNombresMod.Text == "" || this.txtCedulaMod.Text == "" || this.txtPesoMod.Text == "" || this.txtEstaturaMod.Text == "" || this.cmbSexoMod.Text == "")
            {
                MessageBox.Show("Faltan Datos por llenar...Por favor Ingresalos");
            }
            else
            {
                //personas.Cedula = txtCedulaMod.Text;
                personas.Apellidos = txtApellidosMod.Text;
                personas.Nombres = txtNombresMod.Text;
                if (cmbSexoMod.Text == "Masculino")
                    personas.Sexo = "M";
                else
                    personas.Sexo = "F";
                personas.Sexo = cmbSexoMod.Text;
                personas.FechaNacimiento = dtFechaNaciminetoMod.Value;
                personas.Correo = txtCorreoMod.Text;
                try
                {
                    personas.Estatura = int.Parse(txtEstaturaMod.Text);
                    personas.Peso = decimal.Parse(txtPesoMod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                try
                {
                    if (TIC.DatoPersonasDAO.verificarEmail(this.txtCorreoMod.Text) == true)
                    {
                        act = TIC.DatoPersonasDAO.creacion(personas);
                        if (act > 0)
                            MessageBox.Show("Registro Actualizado..");
                        else
                            MessageBox.Show("No se pudo Actualizar el Registro");
                    }
                    else
                    {
                        MessageBox.Show("Error en la Verificacion del Correo");
                        this.txtCorreoMod.Focus();
                    }
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
                    this.cargarGridPersonasMod();
                }
            }
        }
    }
}