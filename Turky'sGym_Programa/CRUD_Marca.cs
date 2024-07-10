using CapaEntidad;
using CapaLógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turky_sGym_Programa
{
    public partial class CRUD_Marca : Form
    {
        public CRUD_Marca()
        {
            InitializeComponent();
            gbMarca.Enabled = false;
            listarMarca();
        }

        public void listarMarca()
        {
            dgvMarca.DataSource = logMarca.Instancia.ListarMarca();
        }

        public void LimpiarVariables()
        {
            lblIDMarca.Text = "00";
            txtNomMarca.Clear();
            cbEstadoMarca.Checked = false;
        }

        private void btnCrearM_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
            btnInsertarM.Visible = true;
            LimpiarVariables();
        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex];
            lblIDMarca.Text = filaActual.Cells[1].Value.ToString();
            txtNomMarca.Text = filaActual.Cells[2].Value.ToString();
            cbEstadoMarca.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnInhabilitarM_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca mr = new entMarca();
                mr.idMarca = int.Parse(lblIDMarca.Text.Trim());
                mr.estMarca = cbEstadoMarca.Checked;
                logMarca.Instancia.DeshabilitarMarca(mr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void btnHabilitarM_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca mr = new entMarca();
                mr.idMarca = int.Parse(lblIDMarca.Text.Trim());
                mr.estMarca = cbEstadoMarca.Checked;
                logMarca.Instancia.HabilitarMarca(mr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void btnInsertarM_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMarca = txtNomMarca.Text.Trim();

                if (string.IsNullOrEmpty(nombreMarca))
                {
                    MessageBox.Show("El nombre de la marca no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                entMarca mr = new entMarca();
                mr.CategoriaID = Convert.ToInt32(cbxCategoriaM.SelectedValue);
                mr.nomMarca = nombreMarca;
                mr.estMarca = cbEstadoMarca.Checked;
                logMarca.Instancia.InsertaMarca(mr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbMarca.Enabled = false;
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CRUD_Marca_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
            cbxCategoriaM.DataSource = logMarca.Instancia.CargarCategoria();
            cbxCategoriaM.DisplayMember = "NomCategoria";
            cbxCategoriaM.ValueMember = "CategoriaID";
        }
        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxCategoriaM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
