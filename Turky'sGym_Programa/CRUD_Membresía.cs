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
    public partial class CRUD_Membresía : Form
    {
        public CRUD_Membresía()
        {
            InitializeComponent();
            listarPlan();
            gbPlanes.Enabled = false;
        }

        public void listarPlan()
        {
            dgvPlan.DataSource = logMembresia.Instancia.ListarMembresia();
        }

        private void LimpiarVariables()
        {
            lbIDMembresia.Text = "00";
            txtMembresia.Clear();
            txtPrecio.Clear();
            cmbServicio.SelectedIndex = 0;
            cbEstado.Checked = false;
        }

        private void CRUD_Membresía_Load(object sender, EventArgs e)
        {

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
                entMembresia pl = new entMembresia();
                pl.idMembresia = int.Parse(txtMembresia.Text.Trim());
                logMembresia.Instancia.DeshabilitarMembresia(pl);
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
                entMembresia pl = new entMembresia();
                pl.idMembresia = int.Parse(lbIDMembresia.Text.Trim());
                logMembresia.Instancia.HabilitarMembresia(pl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPlanes.Enabled = false;
            listarPlan();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMembresia pl = new entMembresia();
                pl.nombreMemb = txtMembresia.Text;
                pl.precio = double.Parse(txtPrecio.Text.Trim());
                //pl.duracion = txtDuracionMem.Text;
                pl.estMembresia = cbEstado.Checked;
                logMembresia.Instancia.InsertaMembresia(pl);
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
            lbIDMembresia.Text = filaActual.Cells[0].Value.ToString();
            txtMembresia.Text = filaActual.Cells[1].Value.ToString();
            txtPrecio.Text = filaActual.Cells[2].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
    
}
