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
    public partial class Crud_Promociones : Form
    {
        public Crud_Promociones()
        {
            InitializeComponent();
            listarPromocion();
            gbPromocion.Enabled = false;
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        public void listarPromocion()
        {
            dgvPromocion.DataSource = logPromocion.Instancia.ListarPromocion();
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
        public void LimpiarVariables()
        {
            lbID.Text = "00";
            cmbTipoProm.SelectedIndex = 0;
            txtNombre.Clear();
            txtDescuento.Clear();
        }
    }
}
