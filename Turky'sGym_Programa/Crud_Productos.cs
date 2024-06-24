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
    public partial class CRUD_Productos : Form
    {
        public CRUD_Productos()
        {
            InitializeComponent();
            listarProducto();
            grbDatosProducto.Enabled = false;
        }

        public void listarProducto()
        {
            dgvStockProducto.DataSource = logProducto.Instancia.ListarProducto();

        }
        public void LimpiarVariables()
        {
            cmbCategoria.SelectedIndex = 0;
            cbMarca.SelectedIndex = 0;
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
        }

        private void CRUD_Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbDatosProducto.Enabled = true;
            btnInsertar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grbDatosProducto.Enabled = true;
            btnModificar.Visible = true;
            btnInsertar.Visible = false;
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto pr = new entProducto();
                pr.idProducto = int.Parse(lbID.Text.Trim());
                logProducto.Instancia.DeshabilitarProducto(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatosProducto.Enabled = false;
            listarProducto();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProducto pr = new entProducto();
                pr.idCategoria = int.Parse(cmbCategoria.Text.Trim());
                pr.marca = cbMarca.Text.Trim();
                pr.tipo = txtDescripcion.Text.Trim();
                pr.cantidad = int.Parse(txtCantidad.Text.Trim());
                pr.precio = int.Parse(txtPrecio.Text.Trim());
                pr.estProducto = cbxEstadoProducto.Checked;
                logProducto.Instancia.InsertaProducto(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatosProducto.Enabled = false;
            listarProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto pr = new entProducto();
                pr.idProducto = int.Parse(lbID.Text.Trim());
                pr.idCategoria = int.Parse(cmbCategoria.Text.Trim());
                pr.marca = cbMarca.Text.Trim();
                pr.tipo = txtDescripcion.Text.Trim();
                pr.cantidad = int.Parse(txtCantidad.Text.Trim());
                pr.precio = double.Parse(txtPrecio.Text.Trim());
                pr.estProducto = cbxEstadoProducto.Checked;
                logProducto.Instancia.EditaProducto(pr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            grbDatosProducto.Enabled = false;
            listarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbDatosProducto.Enabled = false;
        }

        private void dgvStockProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvStockProducto.Rows[e.RowIndex];
            lbID.Text = filaActual.Cells[0].Value.ToString();
            cmbCategoria.Text = filaActual.Cells[1].Value.ToString();
            cbMarca.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            txtCantidad.Text = filaActual.Cells[4].Value.ToString();
            txtPrecio.Text = filaActual.Cells[5].Value.ToString();
            cbxEstadoProducto.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }
    }
}
