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
    public partial class FrmModificarMaterias : Form
    {
        public FrmModificarMaterias()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int act = 0;
            TIC_MATERIAS.DatosMaterias materias = new TIC_MATERIAS.DatosMaterias();
            if (this.txtCarreraMod.Text == "" || this.txtCodigoMod.Text == "" || this.txtCreditosMod.Text == "" || this.txtNivelMod.Text == "" || this.txtNombreMateriaMod.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar...por favor ingresarlos");
            }
            else
            {
                materias.Codigo = txtCodigoMod.Text;
                materias.NombreMateria = txtNombreMateriaMod.Text;
                materias.Carrera = txtCarreraMod.Text;                
                try
                {
                    materias.Nivel = int.Parse(txtNivelMod.Text);
                    materias.Creditos = int.Parse(txtCreditosMod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                try
                {
                    act = TIC_MATERIAS.DatosMateriasDAO.update(materias);
                    if (act > 0)
                        MessageBox.Show("Registro actualizado..");
                    else
                        MessageBox.Show("No se pudo actualizar el registro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void FrmModificarMaterias_Load(object sender, EventArgs e)
        {

        }
    }
}
