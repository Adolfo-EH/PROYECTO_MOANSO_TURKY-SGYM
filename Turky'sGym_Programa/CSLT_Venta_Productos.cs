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
    public partial class CSLT_Venta_Productos : Form
    {
        public CSLT_Venta_Productos()
        {
            InitializeComponent();
            ListarVentaProducto();
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CSLT_Venta_Productos_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
        }

        private void btnBuscarCSLTVenta_Click(object sender, EventArgs e)
        {
            bool? estVenta = ckbEstadoCSLTVenta.Checked ? (bool?)true : (bool?)null;
            DateTime? FechaVenProd = dtpFechaCSLTVenta.Value.Date;
            int? DetalleventaproductoID = string.IsNullOrEmpty(txtIDDetalleCSLTVenta.Text) ? (int?)null : int.Parse(txtIDDetalleCSLTVenta.Text);
            int? VentaproductoID = string.IsNullOrEmpty(txtIDVentaCSLTVenta.Text) ? (int?)null : int.Parse(txtIDVentaCSLTVenta.Text);
            string NomProducto = string.IsNullOrEmpty(txtProductoCSLTVenta.Text) ? null : txtProductoCSLTVenta.Text;
            string NomCategoria = string.IsNullOrEmpty(txtCategoriaCSLTVenta.Text) ? null : txtCategoriaCSLTVenta.Text;
            string NomMarca = string.IsNullOrEmpty(txtMarcaCSLTVenta.Text) ? null : txtMarcaCSLTVenta.Text;
            string NomMetodo = cmbMetodoPagoCSLTVenta.SelectedItem == null ? null : cmbMetodoPagoCSLTVenta.SelectedItem.ToString();

            dgvCSLTVenta.DataSource = logVentaProdCon.Instancia.BuscarVentaProducto(estVenta, FechaVenProd, DetalleventaproductoID, VentaproductoID, NomProducto, NomCategoria, NomMarca, NomMetodo);
            btnBuscarCSLTVenta.Enabled = false;
            btnRegresarCSLTVenta.Enabled = true;
            ListarVentaProducto();
        }

        private void btnRegresarCSLTVenta_Click(object sender, EventArgs e)
        {
            ListarVentaProducto();
            LimpiarItems();
            btnBuscarCSLTVenta.Enabled = true;
            btnRegresarCSLTVenta.Enabled = false;
        }
        private void LimpiarItems()
        {
            ckbEstadoCSLTVenta.Checked = false;
            dtpFechaCSLTVenta.Value = DateTime.Now;
            txtIDDetalleCSLTVenta.Clear();
            txtIDVentaCSLTVenta.Clear();
            txtProductoCSLTVenta.Clear();
            txtCategoriaCSLTVenta.Clear();
            txtMarcaCSLTVenta.Clear();
            cmbMetodoPagoCSLTVenta.SelectedIndex = -1;
        }
        private void ListarVentaProducto()
        {
            dgvCSLTVenta.DataSource = logVentaProdCon.Instancia.ListarVentaProducto();
        }
    }
}
