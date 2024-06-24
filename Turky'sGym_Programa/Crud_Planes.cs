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
    public partial class CRUD_Planes : Form
    {
        public CRUD_Planes()
        {
            InitializeComponent();
            listarPlan();
            gbPlanes.Enabled = false;
        }

        public void listarPlan()
        {
            dgvPlan.DataSource = logPlan.Instancia.ListarPlan();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbPlanes.Enabled = true;
            btnGuardar.Visible = true;
            LimpiarVariables();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlan pl = new entPlan();
                pl.idPlan = int.Parse(lbID.Text.Trim());
                logPlan.Instancia.DeshabilitarPlan(pl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPlanes.Enabled = false;
            listarPlan();
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlan pl = new entPlan();
                pl.idPlan = int.Parse(lbID.Text.Trim());
                logPlan.Instancia.HabilitarPlan(pl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPlanes.Enabled = false;
            listarPlan();
        }

        private void LimpiarVariables()
        {
            lbID.Text = "";
            txtPlan.Clear();
            txtPrecio.Clear();
            cmbServicio.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPlan pl = new entPlan();
                pl.nombrePlan = txtPlan.Text;
                pl.precio = double.Parse(txtPrecio.Text.Trim());
                pl.duracion = dtpDuracion.Value;
                pl.estPlan = cbEstado.Checked;
                logPlan.Instancia.InsertaPlan(pl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPlanes.Enabled = false;
            listarPlan();
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlan.Rows[e.RowIndex];
            lbID.Text = filaActual.Cells[0].Value.ToString();
            txtPlan.Text = filaActual.Cells[1].Value.ToString();
            txtPrecio.Text = filaActual.Cells[2].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}
