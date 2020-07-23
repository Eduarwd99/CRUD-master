using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC_MATERIAS;

namespace CRUD
{
    public partial class FrmIngresarMaterias : Form
    {
        public FrmIngresarMaterias()
        {
            InitializeComponent();
        }

        private void FrmIngresarMaterias_Load(object sender, EventArgs e)
        {
            this.cargarGridMaterias();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarGridMaterias();
            MessageBox.Show("Se Actualizo el GridTable con la BDD...");
        }

        public void cargarGridMaterias()
        {
            DataTable dt = TIC_MATERIAS.DatosMateriasDAO.getAll();
            this.dgMaterias.DataSource = dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Clear();
            this.txtNivel.Clear();
            this.txtNombreMateria.Clear();
            this.txtCreditos.Clear();
            this.txtCarrera.Clear();
            this.txtBorrarRegistro.Clear();

            this.txtCodigo.Focus();
            this.cargarGridMaterias();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaMaterias FBM = new FrmBusquedaMaterias();
            FBM.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            TIC_MATERIAS.DatosMaterias materias = new TIC_MATERIAS.DatosMaterias();
            if (this.txtCarrera.Text == "" || this.txtCodigo.Text == "" || this.txtCreditos.Text == "" || this.txtNivel.Text == "" || this.txtNombreMateria.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar...por favor, ingresarlos");
            }
            else
            {
                materias.Codigo = this.txtCodigo.Text;
                materias.NombreMateria = this.txtNombreMateria.Text;
                materias.Carrera = this.txtCarrera.Text;
                try
                {
                    materias.Nivel = int.Parse(this.txtNivel.Text);
                    materias.Creditos = int.Parse(this.txtCreditos.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                try
                {
                    if (TIC_MATERIAS.DatosMateriasDAO.existeCodigo(this.txtCodigo.Text))
                    {
                        MessageBox.Show("Ese codigo de materia ya existe en la BDD...");
                        return;
                    }
                    else
                    {
                        x = TIC_MATERIAS.DatosMateriasDAO.create(materias);
                        if (x > 0)
                            MessageBox.Show("Registro agregado...");
                        else
                            MessageBox.Show("No se pudo agregar el registro...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.cargarGridMaterias();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int y = 0;
            if (this.txtBorrarRegistro.Text == "")
                this.txtBorrarRegistro.Focus();
            else
            {
                try
                {
                    if (TIC_MATERIAS.DatosMateriasDAO.existeCodigo(this.txtBorrarRegistro.Text))
                    {
                        y = TIC_MATERIAS.DatosMateriasDAO.delete(this.txtBorrarRegistro.Text);
                        if (y > 0)
                        {
                            MessageBox.Show("El registro ha sido borrado con exito...");
                            return;
                        }
                        else
                            MessageBox.Show("No se pudo borrar correctamente el registro en la BDD...");
                    }
                    else
                    {
                        MessageBox.Show("El codigo ingresado no esta almacenado en la BDD...");
                        this.txtBorrarRegistro.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.cargarGridMaterias();
                }
            }
        }

        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            string codigo = dgMaterias[2, fila].Value.ToString();
            if (this.dgMaterias.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                string confirmarMSG = string.Format("¿Está seguro de que desea eliminar al registro seleccionado?");
                if (MessageBox.Show(confirmarMSG, "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = TIC_MATERIAS.DatosMateriasDAO.delete(codigo);
                    if (x > 0)
                        MessageBox.Show("El registro fue eliminado con exito");
                    else
                        MessageBox.Show("No se pudo eliminar el registro");
                    this.cargarGridMaterias();
                }
            }

            FrmModificarMaterias FMM = new FrmModificarMaterias();
            DatosMaterias DM = new DatosMaterias();
            if (this.dgMaterias.Columns[e.ColumnIndex].Name == "linkModificar")
            {
                DM = TIC_MATERIAS.DatosMateriasDAO.getMaterias(codigo);
                FMM.txtCodigoMod.Text = DM.Codigo;
                FMM.txtNombreMateriaMod.Text = DM.NombreMateria;
                FMM.txtCreditosMod.Text = DM.Creditos.ToString();
                FMM.txtCarreraMod.Text = DM.Carrera;
                FMM.txtNivelMod.Text = DM.Nivel.ToString();
                FMM.ShowDialog();
            }
        }
    }
}
