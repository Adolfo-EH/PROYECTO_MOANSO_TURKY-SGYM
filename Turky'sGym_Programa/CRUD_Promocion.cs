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
    public partial class CRUD_Promocion : Form
    {
        public CRUD_Promocion()
        {
            InitializeComponent();
            listarPromocion();
            gbPromocion.Enabled = false;
        }

        public void listarPromocion()
        {
            dgvPromocion.DataSource = logPromocion.Instancia.ListarPromocion();
        }

        public void LimpiarVariables()
        {
            lbID.Text = "00";
            cmbTipoProm.SelectedIndex = 0;
            txtNombre.Clear();
            txtDescuento.Clear();
        }

        private void CRUD_Promocion_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbPromocion.Enabled = true;
            btnGuardar.Visible = true;
            LimpiarVariables();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPromocion pr = new entPromocion();
                pr.idPromocion = int.Parse(lbID.Text.Trim());
                pr.estPromocion = cbxPromocion.Checked;
                logPromocion.Instancia.HabilitarPromocion(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPromocion.Enabled = false;
            listarPromocion();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPromocion pr = new entPromocion();
                pr.idPromocion = int.Parse(lbID.Text.Trim());
                pr.estPromocion = cbxPromocion.Checked;
                logPromocion.Instancia.DeshabilitarPromocion(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPromocion.Enabled = false;
            listarPromocion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPromocion pr = new entPromocion();
                pr.idTipodePromocion = int.Parse(cmbTipoProm.Text.Trim());
                pr.nombre = txtNombre.Text.Trim();
                pr.descuento = double.Parse(txtDescuento.Text.Trim());
                pr.duracion = dtpDuracion.Value;
                pr.estPromocion = cbxPromocion.Checked;
                logPromocion.Instancia.InsertaPromocion(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPromocion.Enabled = false;
            listarPromocion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbPromocion.Enabled = false;
            LimpiarVariables();
        }

        private void dgvPromocion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPromocion.Rows[e.RowIndex];
            lbID.Text = filaActual.Cells[0].Value.ToString();
            cmbTipoProm.Text = filaActual.Cells[1].Value.ToString();
            txtNombre.Text = filaActual.Cells[2].Value.ToString();
            txtDescuento.Text = filaActual.Cells[3].Value.ToString();
            dtpDuracion.Text = filaActual.Cells[4].Value.ToString();
            cbxPromocion.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}
