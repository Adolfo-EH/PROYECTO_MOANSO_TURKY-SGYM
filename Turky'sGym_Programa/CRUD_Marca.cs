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

        private void Marca_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearM_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex];
            lblIDMarca.Text = filaActual.Cells[0].Value.ToString();
            txtNomMarca.Text = filaActual.Cells[1].Value.ToString();
            cbEstadoMarca.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnInhabilitarM_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca mr = new entMarca();
                mr.idMarca = int.Parse(lblIDMarca.Text.Trim());
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
                entMarca mr = new entMarca();
                mr.nombreM = txtNomMarca.Text.Trim();
                mr.estMarca = cbEstadoMarca.Checked;
                logMarca.Instancia.InsertaMarca(mr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
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
    }
}
