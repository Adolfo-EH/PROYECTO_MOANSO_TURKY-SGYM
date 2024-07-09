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
        private Dictionary<int, string> serviciosSeleccionados;
        public CRUD_Membresía()
        {
            InitializeComponent();
            listarPlan();
            gbPlanes.Enabled = false;
            serviciosSeleccionados = new Dictionary<int, string>();
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
            txtDuracionMem.Clear();
            //listServicios.Clear();
            cbEstado.Checked = false;
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CRUD_Membresía_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
            cmbServicio.DataSource = logServicios.Instancia.CargarServicio();
            cmbServicio.DisplayMember = "NomServicio";
            cmbServicio.ValueMember = "ServiciosID";
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
                pl.idMembresia = int.Parse(lbIDMembresia.Text.Trim());
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
            int idMeb;
            try
            {
                entMembresia m = new entMembresia();

                m.nombreMeb = txtMembresia.Text.Trim();
                m.duracion = txtDuracionMem.Text.Trim();
                m.precio = Double.Parse(txtPrecio.Text.Trim());
                m.estMembresia = cbEstado.Checked;

                idMeb = logMembresia.Instancia.InsertaMembresia(m);

                GuardarSerMemb(idMeb);
                LimpiarVariables();
                gbPlanes.Enabled = false;
                listarPlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlan.Rows[e.RowIndex];
            lbIDMembresia.Text = filaActual.Cells[0].Value.ToString();
            txtMembresia.Text = filaActual.Cells[1].Value.ToString();
            txtDuracionMem.Text = filaActual.Cells[3].Value.ToString();
            txtPrecio.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void GuardarSerMemb(int cod)
        {
            foreach (var item in serviciosSeleccionados)
            {
                int servicioID = item.Key;
                logMembresia.Instancia.InsertaSerMemb(servicioID, cod);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener el servicio seleccionado en el ComboBox
            var selectedService = cmbServicio.SelectedItem as DataRowView;

            if (selectedService != null)
            {
                int servicioID = (int)selectedService["ServiciosID"];
                string servicioNombre = selectedService["NomServicio"].ToString();

                // Añadir el servicio al diccionario y al ListBox
                if (!serviciosSeleccionados.ContainsKey(servicioID))
                {
                    serviciosSeleccionados.Add(servicioID, servicioNombre);
                    listServicios.Items.Add(servicioNombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void gbPlanes_Enter(object sender, EventArgs e)
        {

        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
