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
    public partial class FrmBusquedaMaterias : Form
    {
        public FrmBusquedaMaterias()
        {
            InitializeComponent();
        }
        private void FrmBusquedaMaterias_Load(object sender, EventArgs e)
        {
            this.cargaComboMateria();
        }
        private void cargaComboMateria()
        {
            DataTable dt = TIC_MATERIAS.DatosMateriasDAO.getMateriasBusqueda();
            this.cmbCodigo.DataSource = dt;
            this.cmbCodigo.ValueMember = "Codigo";
            this.cmbCodigo.DisplayMember = "Materia_Cod";
        }                
        private void cargarMateria(TIC_MATERIAS.DatosMaterias materia)
        {
            this.txtCodigo.Text = materia.Codigo;
            this.txtNombreMateria.Text = materia.NombreMateria;
            this.txtCarrera.Text = materia.Carrera;
            this.txtCreditos.Text = materia.Creditos.ToString();
            this.txtNivel.Text = materia.Nivel.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            String codigo = this.cmbCodigo.SelectedValue.ToString();
            TIC_MATERIAS.DatosMaterias materias = new TIC_MATERIAS.DatosMaterias();
            materias = TIC_MATERIAS.DatosMateriasDAO.getMaterias(codigo);
            this.cargarMateria(materias);
        }
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = this.cmbCodigo.SelectedValue.ToString();
                if (codigo.Length > 0)
                {
                    TIC_MATERIAS.DatosMaterias materia = new TIC_MATERIAS.DatosMaterias();
                    materia = TIC_MATERIAS.DatosMateriasDAO.getMaterias(codigo);
                    this.cargarMateria(materia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
