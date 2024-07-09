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
    public partial class CRUD_Usuario : Form
    {
        public CRUD_Usuario()
        {
            InitializeComponent();
            listarUsuario();
            gbAdministrador.Enabled = false;
        }
        public void LimpiarVariables()
        {
            lblIDAdmin.Text = "00";
            txtUsuarioAd.Clear();
            cbEstadoAdmin.Checked = false;
        }
        public void listarUsuario()
        {
            dgvAdministrador.DataSource = logUsuario.Instancia.ListarUsuario();
        }
        private void lblVentaServicios_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbEstadoAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearAd_Click(object sender, EventArgs e)
        {
            gbAdministrador.Enabled = true;
            btnAceptarAd.Visible = true;
            LimpiarVariables();
        }

        private void btnHabilitarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario User = new entUsuario();
                User.UsuarioID = int.Parse(lblIDAdmin.Text.Trim());
                logUsuario.Instancia.HabilitarUsuario(User);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            LimpiarVariables();
            gbAdministrador.Enabled = false;
            listarUsuario();
        }

        private void btnEditarAd_Click(object sender, EventArgs e)
        {
            gbAdministrador.Enabled = true;
            btnActualizarAd.Visible = true;
            btnAceptarAd.Visible = false;
        }

        private void btnCancelarAd_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbAdministrador.Enabled = false;
        }

        private void dgvAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvAdministrador.Rows[e.RowIndex];
            lblIDAdmin.Text = filaActual.Cells[0].Value.ToString();
            txtUsuarioAd.Text = filaActual.Cells[2].Value.ToString();
            txtPassAd.Text = filaActual.Cells[3].Value.ToString();
            cbEstadoAdmin.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void CRUD_Usuario_Load(object sender, EventArgs e)
        {
            cbxTipoUser.DataSource = logUsuario.Instancia.CargarTipoUsuario();
            cbxTipoUser.DisplayMember = "NomTipouser";
            cbxTipoUser.ValueMember = "TipousuarioID";
        }

        private void btnInhabilitarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario User = new entUsuario();
                User.UsuarioID = int.Parse(lblIDAdmin.Text.Trim());
                logUsuario.Instancia.DeshabilitarUsuario(User);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            LimpiarVariables();
            gbAdministrador.Enabled = false;
            listarUsuario();
        }

        private void btnAceptarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario user = new entUsuario();
                user.TipoUsuarioID = Convert.ToInt32(cbxTipoUser.SelectedValue);
                user.Usuario = txtUsuarioAd.Text.Trim();
                user.Contraseña = txtPassAd.Text.Trim();
                user.estUsuario = cbEstadoAdmin.Checked;
                logUsuario.Instancia.InsertarUsuario(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbAdministrador.Enabled = false;
            listarUsuario();
        }

        private void btnActualizarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario user = new entUsuario();
                user.UsuarioID = int.Parse(lblIDAdmin.Text.Trim());
                user.TipoUsuarioID = Convert.ToInt32(cbxTipoUser.SelectedValue);
                user.Usuario = txtUsuarioAd.Text.Trim();
                user.Contraseña = txtPassAd.Text.Trim();
                user.estUsuario = cbEstadoAdmin.Checked;
                logUsuario.Instancia.ModificarUsuario(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbAdministrador.Enabled = false;
            listarUsuario();
        }

        private void cbxTipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
