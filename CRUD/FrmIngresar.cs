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
        public void cargarGridPersonas()
        {
            DataTable dt = TIC.DatoPersonasDAO.getAll();
            this.dgPersonas.DataSource = dt;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            TIC.DatosPersonas personas = new TIC.DatosPersonas();
            if (this.txtCorreo.Text == "" || this.txtApellidos.Text == "" || this.txtNombres.Text == "" || this.txtCedula.Text == "" || this.txtPeso.Text == "" || this.txtEstatura.Text == "" || this.cmbSexo.Text == "")
            {
                MessageBox.Show("Faltan Datos por llenar...Por favor Ingresalos");
            }
            else
            {
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
                try
                {
                    personas.Estatura = int.Parse(txtEstatura.Text);
                    personas.Peso = decimal.Parse(txtPeso.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                try
                {
                    if (TIC.DatoPersonasDAO.existeCedula(this.txtCedula.Text))
                    {
                        MessageBox.Show("Esa cedula ya existe en la BDD...");
                        return; //Abandonar
                    }
                    else
                    {
                        if (TIC.DatoPersonasDAO.verificarEmail(this.txtCorreo.Text) == true)
                        {
                            x = TIC.DatoPersonasDAO.creacion(personas);
                            if (x > 0)
                                MessageBox.Show("Registro Agregado..");
                            else
                                MessageBox.Show("No se pudo Agregar el Registro");
                        }
                        else
                        {
                            MessageBox.Show("Error en la Verificacion del Correo");
                            this.txtCorreo.Focus();
                        }
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
                    this.cargarGridPersonas();
                }
            }
        }
        private void button1_Click/*btnBorrar*/(object sender, EventArgs e)
        {
            int y = 0;
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
                        if (y > 0)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.cargarGridPersonas();
                }
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtCedula.Clear();
            this.txtApellidos.Clear();
            this.txtNombres.Clear();
            this.cmbSexo.Text = "";
            this.txtCorreo.Clear();
            this.txtEstatura.Clear();
            this.txtPeso.Clear();
            this.txtBorrarRegistro.Clear();
            this.txtCedula.Focus();
            this.cargarGridPersonas();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarGridPersonas();
            MessageBox.Show("Se Actualizo el GridTable con la BDD...");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            //MessageBox.Show("fila: " + fila.ToString() + ", col: " + col.ToString());
            //1. recuperar la cedula de la fila actual
            //string cedula = dgPersonas["Cedula", fila].Value.ToString();
            string cedula = dgPersonas[2, fila].Value.ToString();
            
            // 2.Detectar click en link eliminar
            if (this.dgPersonas.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                string confirmarMSG = string.Format("¿Está seguro de que desea eliminar al registro seleccionado?"/*, dgPersonas.Rows[e.RowIndex].Cells["NameColumn"].Value*/);
                //3. Preguntar al usuario si desea eliminar 
                if (MessageBox.Show(confirmarMSG, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //4. En caso afirmativo, eliminar el registro y actualizar el dgv.dgPersonas.Rows.RemoveAt(e.RowIndex);
                    int x = TIC.DatoPersonasDAO.delete(cedula);
                    if(x > 0)
                        MessageBox.Show("El Registro fue Eliminado con Exito");
                    else
                        MessageBox.Show("No se Pudo Eliminar el Registro");
                    this.cargarGridPersonas();                    
                }
            }

            // Si se detecta click en link modificar
            if (this.dgPersonas.Columns[e.ColumnIndex].Name == "linkModificar")
            {
                FrmModificar FM = new FrmModificar();                
                DatosPersonas DP = new DatosPersonas();
                DP = TIC.DatoPersonasDAO.getPersona(cedula);

                FM.txtCedulaMod.Text = DP.Cedula;
                FM.txtApellidosMod.Text = DP.Apellidos;
                FM.txtNombresMod.Text = DP.Nombres;
                FM.cmbSexoMod.Text = DP.Sexo;
                FM.dtFechaNaciminetoMod.Value = DP.FechaNacimiento;
                FM.txtCorreoMod.Text = DP.Correo;
                FM.txtEstaturaMod.Text = DP.Estatura.ToString();
                FM.txtPesoMod.Text = DP.Peso.ToString();
                FM.ShowDialog(); //Mostrar formulario como tipo dialogo
            }
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dgPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}