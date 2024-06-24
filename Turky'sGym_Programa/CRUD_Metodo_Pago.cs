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
    public partial class CRUD_Metodo_Pago : Form
    {
        public CRUD_Metodo_Pago()
        {
            InitializeComponent();
            listarMetodoPago();
            groupMetodo.Enabled = false;
        }

        public void listarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }

        public void LimpiarVariables()
        {
            lbID.Text = "00";
            txtNombre.Clear();
            txtTipo.Clear();
        }

        private void CRUD_Metodo_Pago_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupMetodo.Enabled = true;
            btnInsertar.Visible = true;
            LimpiarVariables();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();
                mp.idMetodoPago = int.Parse(lbID.Text.Trim());
                mp.estMetodoPago = cbxEstadoMetodoPago.Checked;
                logMetodoPago.Instancia.HabilitarMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupMetodo.Enabled = false;
            listarMetodoPago();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();
                mp.idMetodoPago = int.Parse(lbID.Text.Trim());
                logMetodoPago.Instancia.DeshabilitarMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupMetodo.Enabled = false;
            listarMetodoPago();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();
                mp.nombre = txtNombre.Text.Trim();
                mp.tipo = txtTipo.Text.Trim();
                mp.estMetodoPago = cbxEstadoMetodoPago.Checked;
                logMetodoPago.Instancia.InsertaMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupMetodo.Enabled = false;
            listarMetodoPago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupMetodo.Enabled = false;
        }

        private void dgvMetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];
            lbID.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtTipo.Text = filaActual.Cells[2].Value.ToString();
            cbxEstadoMetodoPago.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}
