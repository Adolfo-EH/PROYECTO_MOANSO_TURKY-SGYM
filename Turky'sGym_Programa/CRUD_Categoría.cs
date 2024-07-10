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
using Turky_sGym_Programa;

namespace Turky_sGym_Programa
{
    public partial class CRUD_Categoría : Form
    {
        public CRUD_Categoría()
        {
            InitializeComponent();
            listarCategoria();
            gbCategoría.Enabled = false;
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }

        public void LimpiarVariables()
        {
            lblIDCat.Text = "00";
            txtNomCat.Clear();
            cbEstadoCategoría.Checked = false;
        }

        private void CRUD_Categoría_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
        }

        public void listarCategoria()
        {
            dgvCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            gbCategoría.Enabled = true;
            btnInsertarC.Visible = true;
            LimpiarVariables();
        }

        private void dgvCategoría_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInhabilitarC_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria Cat = new entCategoria();
                Cat.CategoriaID = int.Parse(lblIDCat.Text.Trim());
                logCategoria.Instancia.DeshabilitarCategoria(Cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbCategoría.Enabled = false;
            listarCategoria();
        }

        private void btnInsertarC_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCategoria = txtNomCat.Text.Trim();

                if (string.IsNullOrEmpty(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (logCategoria.Instancia.ExisteNombreCategoria(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría ya existe. Por favor, elija otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    entCategoria Cat = new entCategoria();
                    Cat.NomCategoria = nombreCategoria;
                    Cat.estCategoria = cbEstadoCategoría.Checked;
                    logCategoria.Instancia.InsertaCategoria(Cat);
                    LimpiarVariables();
                    gbCategoría.Enabled = false;
                    listarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            gbCategoría.Enabled = false;
            listarCategoria();
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbCategoría.Enabled = false;
        }

        private void btnHabilitarC_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria Cat = new entCategoria();
                Cat.CategoriaID = int.Parse(lblIDCat.Text.Trim());
                logCategoria.Instancia.HabilitarCategoria(Cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbCategoría.Enabled = false;
            listarCategoria();
        }

        private void dgvCategoria_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex];
            lblIDCat.Text = filaActual.Cells[0].Value.ToString();
            txtNomCat.Text = filaActual.Cells[1].Value.ToString();
            cbEstadoCategoría.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
