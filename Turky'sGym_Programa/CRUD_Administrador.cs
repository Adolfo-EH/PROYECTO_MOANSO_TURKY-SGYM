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
    public partial class CRUD_Administrador : Form
    {
        public CRUD_Administrador()
        {
            InitializeComponent();
            listarAdministrador();
            gbAdministrador.Enabled = false;
        }
        public void LimpiartVariables()
        {
            lblIDAdmin.Text = "00";
            txtUsuarioAd.Clear();
            cbEstadoAdmin.Checked = false;
        }
        public void listarAdministrador()
        {
            dgvAdministrador.DataSource = logAdminisrador.Instancia.ListarAdministrador();
        }

        private void btnCrearAd_Click(object sender, EventArgs e)
        {
            gbAdministrador.Enabled = true;
            btnAceptarAd.Visible = true;
            LimpiartVariables();
        }

        private void btnHabilitarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entAdministrador Admin = new entAdministrador();
                Admin.AdministradorID = int.Parse(lblIDAdmin.Text.Trim());
                logAdminisrador.Instancia.HabilitarAdministrador(Admin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            LimpiartVariables();
            gbAdministrador.Enabled = false;
            listarAdministrador();
        }

        private void btnInhabilitarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entAdministrador Admin = new entAdministrador();
                Admin.AdministradorID = int.Parse(lblIDAdmin.Text.Trim());
                logAdminisrador.Instancia.DeshabilitarAdministrador(Admin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiartVariables();
            gbAdministrador.Enabled = false;
            listarAdministrador();
        }

        private void btnEditarAd_Click(object sender, EventArgs e)
        {
            gbAdministrador.Enabled = true;
            btnActualizarAd.Visible = true;
            btnAceptarAd.Visible = false;
        }

        private void btnRegresarAd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAd_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario = txtUsuarioAd.Text.Trim();
                if (logAdminisrador.Instancia.ExisteUsuarioAdministrador(Usuario))
                {
                    MessageBox.Show("El nombre de la usuario ya existe. Por favor, elija otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    entAdministrador Admin = new entAdministrador();
                    Admin.Usuario = Usuario;
                    Admin.Contraseña = txtPassAd.Text; ;
                    Admin.estAdministrador = cbEstadoAdmin.Checked;
                    logAdminisrador.Instancia.InsertarAdministrador(Admin);
                    LimpiartVariables();
                    gbAdministrador.Enabled = false;
                    listarAdministrador();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiartVariables();
            gbAdministrador.Enabled = false;
            listarAdministrador();
        }

        private void btnActualizarAd_Click(object sender, EventArgs e)
        {
            try
            {
                entAdministrador Admin = new entAdministrador();
                Admin.AdministradorID = int.Parse(lblIDAdmin.Text.Trim());
                Admin.Usuario = txtUsuarioAd.Text.Trim();
                Admin.Contraseña = txtPassAd.Text.Trim();
                Admin.estAdministrador = cbEstadoAdmin.Checked;
                logAdminisrador.Instancia.ModificarAdministrador(Admin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiartVariables();
            gbAdministrador.Enabled = false;
            listarAdministrador();
        }

        private void btnCancelarAd_Click(object sender, EventArgs e)
        {
            LimpiartVariables();
            gbAdministrador.Enabled = false;
        }

        private void dgvAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvAdministrador.Rows[e.RowIndex];
            lblIDAdmin.Text = filaActual.Cells[0].Value.ToString();
            txtUsuarioAd.Text = filaActual.Cells[1].Value.ToString();
            txtPassAd.Text = filaActual.Cells[2].Value.ToString();
            cbEstadoAdmin.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}
