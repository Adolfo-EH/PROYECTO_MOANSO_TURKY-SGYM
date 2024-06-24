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
    public partial class CRUD_Servicios : Form
    {
        public CRUD_Servicios()
        {
            InitializeComponent();
            gbServicio.Enabled = false;
            listarServicio();
        }
        public void listarServicio()
        {
            dgvServicios.DataSource = logServicios.Instancia.ListarServicio();
        }

        public void LimpiarVariables()
        {
            lblIDSer.Text = "00";
            txtNomSer.Clear();
            cbEstadoServicio.Checked = false;
        }

        private void lblVentaServicios_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Servicios_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearS_Click(object sender, EventArgs e)
        {
            gbServicio.Enabled = true;
        }

        private void dgvServicios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow filaActual = dgvServicios.Rows[e.RowIndex];
            lblIDSer.Text = filaActual.Cells[0].Value.ToString();
            txtNomSer.Text = filaActual.Cells[1].Value.ToString();
            cbEstadoServicio.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnInhabilitarS_Click(object sender, EventArgs e)
        {
            try
            {
                entServicios sv = new entServicios();
                sv.idServicio = int.Parse(lblIDSer.Text.Trim());
                logServicios.Instancia.DeshabilitarServicio(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbServicio.Enabled = false;
            listarServicio();
        }

        private void btnHabilitarS_Click(object sender, EventArgs e)
        {
            try
            {
                entServicios sv = new entServicios();
                sv.idServicio = int.Parse(lblIDSer.Text.Trim());
                logServicios.Instancia.HabilitarServicio(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbServicio.Enabled = false;
            listarServicio();
        }

        private void btnInsertarS_Click(object sender, EventArgs e)
        {
            try
            {
                entServicios sv = new entServicios();
                sv.nombreSV = txtNomSer.Text.Trim();
                sv.estServicio = cbEstadoServicio.Checked; 
                logServicios.Instancia.InsertaServicio(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbServicio.Enabled = false;
            listarServicio();
        }

        private void btnCancelarS_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbServicio.Enabled = false;
        }
    }
}
