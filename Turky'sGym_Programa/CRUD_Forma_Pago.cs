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
    public partial class CRUD_Forma_Pago : Form
    {
        public CRUD_Forma_Pago()
        {
            InitializeComponent();
            listarFormaPago();
            groupForma.Enabled = false;
        }
        public void listarFormaPago()
        {
            dgvFormaPago.DataSource = logFormaPago.Instancia.ListarFormaPago();
        }
        public void LimpiarVariables()
        {
            lbIDFP.Text = "00";
            txtTipoFP.Text = string.Empty;  
        }
        private void dgvFormaPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvFormaPago.Rows[e.RowIndex];
            lbIDFP.Text = filaActual.Cells[0].Value.ToString();
            txtTipoFP.Text = filaActual.Cells[1].Value.ToString();
            cbxEstadoFP.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void CRUD_Forma_Pago_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoFP_Click(object sender, EventArgs e)
        {
            groupForma.Enabled = true;
            btnInsertarFP.Visible = true;
            LimpiarVariables();
        }

        private void btnHabilitarFP_Click(object sender, EventArgs e)
        {
            try
            {
                entFormaPago fp = new entFormaPago();
                fp.idFormaPago = int.Parse(lbIDFP.Text.Trim());
                fp.estFormaPago = cbxEstadoFP.Checked;
                logFormaPago.Instancia.HabilitarFormaPago(fp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupForma.Enabled = false;
            listarFormaPago();
        }

        private void btnInhabilitarFP_Click(object sender, EventArgs e)
        {
            try
            {
                entFormaPago fp = new entFormaPago();
                fp.idFormaPago = int.Parse(lbIDFP.Text.Trim());
                logFormaPago.Instancia.DeshabilitarFormaPago(fp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupForma.Enabled = false;
            listarFormaPago();
        }

        private void btnInsertarFP_Click(object sender, EventArgs e)
        {
            try
            {
                entFormaPago fp = new entFormaPago();
                fp.nombreF = txtTipoFP.Text.Trim();   
                fp.estFormaPago = cbxEstadoFP.Checked;
                logFormaPago.Instancia.InsertarFormaPago(fp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupForma.Enabled = false;
            listarFormaPago();
        }

        private void btnCancelarFP_Click(object sender, EventArgs e)
        {
            groupForma.Enabled = false;
        }

        private void btnRegresarFP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
