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
    public partial class CORE_VENTA_PRODUCTOS : Form
    {
        public CORE_VENTA_PRODUCTOS()
        {
            InitializeComponent();
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CORE_VENTA_PRODUCTOS_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();

            cmbCategoria.DataSource = logProducto.Instancia.CargarCategoria();
            cmbCategoria.DisplayMember = "NomCategoria";
            cmbCategoria.ValueMember = "CategoriaID";

            cmbPromocion.DataSource = logPromocion.Instancia.CargarPromocion(1);
            cmbPromocion.DisplayMember = "NomPromocion";
            cmbPromocion.ValueMember = "PromocionID";

            cmbTipoMetodo.DataSource = logMetodoPago.Instancia.CargarTipoMetodoPago();
            cmbTipoMetodo.DisplayMember = "NomTipometodoP";
            cmbTipoMetodo.ValueMember = "TipometodopagoID";

            cmbFormaPago.DataSource = logFormaPago.Instancia.CargarFormaPago();
            cmbFormaPago.DisplayMember = "NomForma";
            cmbFormaPago.ValueMember = "FormadepagoID";
        }

        public static int confilas = 0;
        public static decimal MontoPagar = 0;
        public static decimal AplicarDescuento(decimal precio, decimal descuentoPorcentaje)
        {
            return precio - (precio * (descuentoPorcentaje / 100));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDetVentaProd dProd = new entDetVentaProd();
            entProducto Prod = new entProducto();

            if ((lbID.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text)))
                {
                    if (confilas == 0)
                    {
                        dtgVentaProductos.Rows.Add(lbID.Text, cmbNombre.Text, txtDescProducto.Text, txtCantidad.Text, txtPrecioUni.Text, cmbPromocion.Text);
                        decimal precioTotal = Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[3].Value) * Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[4].Value);
                        dtgVentaProductos.Rows[confilas].Cells[6].Value = precioTotal;
                        decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocion.SelectedValue));
                        decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[6].Value), descuento);
                        dtgVentaProductos.Rows[confilas].Cells[7].Value = precioDescuento;
                        confilas++;
                    }
                    else
                    {
                        dtgVentaProductos.Rows.Add(lbID.Text, cmbNombre.Text, txtDescProducto.Text, txtCantidad.Text, txtPrecioUni.Text, cmbPromocion.Text);
                        decimal precioTotal = Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[3].Value) * Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[4].Value);
                        dtgVentaProductos.Rows[confilas].Cells[6].Value = precioTotal;
                        decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocion.SelectedValue));
                        decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[6].Value), descuento);
                        dtgVentaProductos.Rows[confilas].Cells[7].Value = precioDescuento;
                        confilas++;
                    }
                    //Limpiar();
                }
                MontoPagar = 0;
                foreach (DataGridViewRow Fila in dtgVentaProductos.Rows)
                {
                    MontoPagar += Convert.ToDecimal(Fila.Cells[7].Value);
                }
                txtMontoPagar.Text = MontoPagar.ToString();
            }
        }

        private void btnRegistroVProducto_Click(object sender, EventArgs e)
        {
            int idVen;
            try
            {
                entVentaProd Prod = new entVentaProd();

                Prod.idAdmin = 1;
                Prod.idMetodoPago = Convert.ToInt32(cmbMetodoPago.SelectedValue);
                Prod.idFormaPago = Convert.ToInt32(cmbFormaPago.SelectedValue);
                Prod.MontoVenta = Convert.ToDecimal(txtMontoPagar.Text);
                Prod.fechVentaProd = Convert.ToDateTime(dateTimePicker1.Value);
                Prod.estVentaProd = true;
                idVen = logVentaProd.Instancia.InsertarVentaProd(Prod);

                GrabarDetalle(idVen);
                MessageBox.Show("Se guardó correctamente la Venta del Producto");
                //ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }

        private void GrabarDetalle(int cod)
        {
            foreach (DataGridViewRow Fila in dtgVentaProductos.Rows)
            {
                entDetVentaProd dProd = new entDetVentaProd();
                dProd.idVentaProd = cod;
                entProducto prod = new entProducto();
                entPromocion prom = new entPromocion();

                prod.idProducto = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                dProd.idProducto = prod;
                dProd.idProducto.idProducto = prod.idProducto;

                // Obtener PromocionID basado en el nombre de la promoción mostrado en la fila
                string nombrePromocion = Fila.Cells[5].Value.ToString();
                int promocionID = ObtenerPromocionIDPorNombre(nombrePromocion);
                prom.idPromocion = promocionID;
                dProd.idPromocion = prom;
                dProd.idPromocion.idPromocion = prom.idPromocion;

                dProd.cantProducto = Convert.ToInt32(Fila.Cells[3].Value.ToString());
                dProd.precUnitario = Convert.ToDecimal(Fila.Cells[4].Value.ToString());
                dProd.precDescuento = Convert.ToDecimal(Fila.Cells[7].Value.ToString());
                dProd.precTotal = Convert.ToDecimal(Fila.Cells[6].Value.ToString());

                logVentaProd.Instancia.InsertarDetVentaProd(dProd);
            }
        }

        // Método para obtener el PromocionID basado en el nombre de la promoción
        private int ObtenerPromocionIDPorNombre(string nombrePromocion)
        {
            int promocionID = 0;

            // Recorrer la lista de promociones cargada en el ComboBox cmbPromocion
            foreach (DataRowView item in cmbPromocion.Items)
            {
                if (item.Row["NomPromocion"].ToString() == nombrePromocion)
                {
                    promocionID = Convert.ToInt32(item.Row["PromocionID"]);
                    break;
                }
            }

            return promocionID;
        }


        private void ActualizarGrid()
        {/*
            //MessageBox.Show("formulario de datos se cierra....de si encuentra instancia");
            TransaccionGridPedido formGridPedido = Application.OpenForms.OfType<TransaccionGridPedido>().FirstOrDefault();

            if (formGridPedido != null)  //Si encuentra una instancia abierta
            {
                //MessageBox.Show("Instancia abierta!!! instancia");
                formGridPedido.ListarPedidos();
                formGridPedido.Refresh();
            }*/
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                MontoPagar = MontoPagar - Convert.ToDecimal(dtgVentaProductos.Rows[dtgVentaProductos.CurrentRow.Index].Cells[6].Value);
                txtMontoPagar.Text = MontoPagar.ToString();
                dtgVentaProductos.Rows.RemoveAt(dtgVentaProductos.CurrentRow.Index);
                confilas--;
            }
        }

        private void cmbTipoMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMetodo.SelectedValue != null)
            {
                if (cmbTipoMetodo.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cmbTipoMetodo.SelectedValue;
                    int idTipo = Convert.ToInt32(drv["TipometodopagoID"]);
                    cmbMetodoPago.DataSource = logMetodoPago.Instancia.CargarMetodoPago(idTipo);
                }
                else
                {
                    int idTipo = Convert.ToInt32(cmbTipoMetodo.SelectedValue);
                    cmbMetodoPago.DataSource = logMetodoPago.Instancia.CargarMetodoPago(idTipo);
                }
                cmbMetodoPago.DisplayMember = "NomMetodo";
                cmbMetodoPago.ValueMember = "MetododepagoID";
            }
        }     

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                if (cmbCategoria.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cmbCategoria.SelectedValue;
                    int idCategoria = Convert.ToInt32(drv["CategoriaID"]);
                    cmbNombre.DataSource = logProducto.Instancia.CargarNombre(idCategoria);
                }
                else
                {
                    int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                    cmbNombre.DataSource = logProducto.Instancia.CargarNombre(idCategoria);
                }
                cmbNombre.DisplayMember = "NomProducto";
                cmbNombre.ValueMember = "ProductosID";
            }
        }
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedValue != null)
            {
                if (cmbNombre.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cmbNombre.SelectedValue;
                    int idProducto= Convert.ToInt32(drv["ProductosID"]);
                    entProducto Prod = logProducto.Instancia.BuscarProductoId(idProducto);
                    if (Prod != null && (Prod.estProducto = true))
                    {
                        lbID.Text = Convert.ToString(Prod.idProducto);
                        txtDescProducto.Text = Convert.ToString(Prod.Descripcion);
                        txtStock.Text = Convert.ToString(Prod.cantidad);
                        txtPrecioUni.Text = Convert.ToString(Prod.precio);
                    }
                }
                else
                {
                    int idProducto = Convert.ToInt32(cmbNombre.SelectedValue);
                    entProducto Prod = logProducto.Instancia.BuscarProductoId(idProducto);
                    if (Prod != null && (Prod.estProducto = true))
                    {
                        lbID.Text = Convert.ToString(Prod.idProducto);
                        txtDescProducto.Text = Convert.ToString(Prod.Descripcion);
                        txtStock.Text = Convert.ToString(Prod.cantidad);
                        txtPrecioUni.Text = Convert.ToString(Prod.precio);
                    }
                }
            }
        }
    }
}
