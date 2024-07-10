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
    public partial class CRUD_Clientes : Form
    {
        public CRUD_Clientes()
        {
            InitializeComponent();
            grbDatCli.Enabled = false;
            listarClientes();
        }

        public void listarClientes()
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarClientes();
            //ancho de la row 1
            dgvClientes.Columns[1].Width = 500;
        }
        public void LimpiarVariables()
        {
            txtDNICli.Clear();
            txtnomCli.Clear();
            cbxestCli.Checked = false;
            dtpFecNac.Value = DateTime.Now;
            txtTelCli.Clear();
        }
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClientes.Rows[e.RowIndex];
            txtDNICli.Text = filaActual.Cells[0].Value.ToString();
            txtnomCli.Text = filaActual.Cells[1].Value.ToString();
            dtpFecNac.Value = Convert.ToDateTime(filaActual.Cells[2].Value);
            txtTelCli.Text = filaActual.Cells[3].Value.ToString();
            cbxestCli.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            grbDatCli.Enabled = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            txtDNICli.Enabled = true;
            LimpiarVariables();
        }

        private void btnDeshabilitarCli_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cl = new entCliente();
                cl.ClienteID = int.Parse(txtDNICli.Text.Trim());
                cl.estClienteMemb = cbxestCli.Checked;
                logCliente.Instancia.DeshabilitarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarClientes();
        }

        private void btnHabilitarCli_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cl = new entCliente();
                cl.ClienteID = int.Parse(txtDNICli.Text.Trim());
                cl.estClienteMemb = cbxestCli.Checked;
                logCliente.Instancia.HabilitarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string clienteIDText = txtDNICli.Text.Trim();
                string telefonoText = txtTelCli.Text.Trim();

                if (clienteIDText.Length != 8 || !int.TryParse(clienteIDText, out int clienteID))
                {
                    MessageBox.Show("No es un DNI correcto");
                    return;
                }

                if (telefonoText.Length != 9 || telefonoText[0] != '9' || !int.TryParse(telefonoText, out int telefono))
                {
                    MessageBox.Show("No es un Telefono correcto");
                    return;
                }

                entCliente cl = new entCliente();
                cl.ClienteID = clienteID;
                cl.NomCliente = txtnomCli.Text.Trim();
                cl.FechaNac = dtpFecNac.Value;
                cl.Telefono = telefono;
                cl.estClienteMemb = cbxestCli.Checked;

                logCliente.Instancia.InsertarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grbDatCli.Enabled = false;
            btnModificar.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grbDatCli.Enabled = true;
            btnModificar.Visible = true;
            btnGuardar.Visible = false;
            txtDNICli.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string telefonoText = txtTelCli.Text.Trim();

                if (telefonoText.Length != 9 || telefonoText[0] != '9' || !int.TryParse(telefonoText, out int telefono))
                {
                    MessageBox.Show("No es un Telefono correcto");
                    return;
                }

                entCliente cl = new entCliente();
                cl.ClienteID = int.Parse(txtDNICli.Text.Trim());
                cl.NomCliente = txtnomCli.Text.Trim();
                cl.FechaNac = dtpFecNac.Value;
                cl.Telefono = telefono;
                cl.estClienteMemb = cbxestCli.Checked;
                logCliente.Instancia.EditarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarClientes();
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CRUD_Clientes_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
        }
    }
}
