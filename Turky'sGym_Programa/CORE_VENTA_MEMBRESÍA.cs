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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Turky_sGym_Programa
{
    public partial class CORE_VENTA_MEMBRESÍA : Form
    {
        public CORE_VENTA_MEMBRESÍA()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            cbxTipoMetodo.Enabled = false;
            cbxMetodo.Enabled = false;
            cbxForma.Enabled = false;
            btnInsertarVMem.Enabled = false;
            btnAnularVMem.Enabled = false;
        }
        private void LimpiarVariables()
        {
            lblIDMemb.Text = "00";
            txbDNI_Cliente.Clear();
            txbNombreCliente.Clear();
            txbTelefonoCliente.Clear();
            txtDuracion.Clear();
            txtPrecio.Clear();
            txtComent.Clear();
            txtMontoTotal.Clear();
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CORE_VENTA_MEMBRESÍA_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();

            cbxMembresia.DataSource = logMembresia.Instancia.CargarMembresia();
            cbxMembresia.DisplayMember = "NomMembresia";
            cbxMembresia.ValueMember = "MembresiaID";

            cmbPromocionM.DataSource = logPromocion.Instancia.CargarPromocion(2);
            cmbPromocionM.DisplayMember = "NomPromocion";
            cmbPromocionM.ValueMember = "PromocionID";

            cbxTipoMetodo.DataSource = logMetodoPago.Instancia.CargarTipoMetodoPago();
            cbxTipoMetodo.DisplayMember = "NomTipometodoP";
            cbxTipoMetodo.ValueMember = "TipometodopagoID";

            cbxForma.DataSource = logFormaPago.Instancia.CargarFormaPago();
            cbxForma.DisplayMember = "NomForma";
            cbxForma.ValueMember = "FormadepagoID";
        }

        public static int confilas = 0;
        public static decimal MontoPagar = 0;
        public static decimal AplicarDescuento(decimal precio, decimal descuentoPorcentaje)
        {
            return precio - (precio * (descuentoPorcentaje / 100));
        }
        private int ObtenerPromocionIDPorNombre(string nombrePromocion)
        {
            int promocionID = 0;

            foreach (DataRowView item in cmbPromocionM.Items)
            {
                if (item.Row["NomPromocion"].ToString() == nombrePromocion)
                {
                    promocionID = Convert.ToInt32(item.Row["PromocionID"]);
                    break;
                }
            }

            return promocionID;
        }

        private void cbxTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            CSLT_Venta_Membresía mainForm = new CSLT_Venta_Membresía();
            mainForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            txbDNI_Cliente.Focus();

            if (!int.TryParse(txbDNI_Cliente.Text, out int ClienteID))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el cliente
            entCliente cl = logCliente.Instancia.BuscarClienteID(ClienteID);

            if (cl != null && cl.ClienteID != 0)
            {
                txbDNI_Cliente.Text = cl.ClienteID.ToString();
                txbNombreCliente.Text = cl.NomCliente;
                txbTelefonoCliente.Text = cl.Telefono.ToString();
                FechaNacCliM.Text = cl.FechaNac.ToString();

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                cbxTipoMetodo.Enabled = true;
                cbxMetodo.Enabled = true;
                cbxForma.Enabled = true;
                btnInsertarVMem.Enabled = true;
                btnAnularVMem.Enabled = true;

            }
            else
            {
                MessageBox.Show("El cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbDNI_Cliente.Text = "";
                txbNombreCliente.Text = "";
                txbTelefonoCliente.Text = "";
                FechaNacCliM.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTipoMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMetodo.SelectedValue != null)
            {
                if (cbxTipoMetodo.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cbxTipoMetodo.SelectedValue;
                    int idTipo = Convert.ToInt32(drv["TipometodopagoID"]);
                    cbxMetodo.DataSource = logMetodoPago.Instancia.CargarMetodoPago(idTipo);
                }
                else
                {
                    int idTipo = Convert.ToInt32(cbxTipoMetodo.SelectedValue);
                    cbxMetodo.DataSource = logMetodoPago.Instancia.CargarMetodoPago(idTipo);
                }
                cbxMetodo.DisplayMember = "NomMetodo";
                cbxMetodo.ValueMember = "MetododepagoID";
            }
        }
        private void cbxTipoPlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxMembresia.SelectedValue != null)
            {
                if (cbxMembresia.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)cbxMembresia.SelectedValue;
                    int idMembresia = Convert.ToInt32(drv["MembresiaID"]);
                    entMembresia Memb = logMembresia.Instancia.BuscarMembresiaID(idMembresia);
                    if (Memb != null && (Memb.estMembresia = true))
                    {
                        lblIDMemb.Text = Convert.ToString(Memb.idMembresia);
                        txtDuracion.Text = Convert.ToString(Memb.duracion);
                        txtPrecio.Text = Convert.ToString(Memb.precio);
                    }
                }
                else
                {
                    int idMembresia = Convert.ToInt32(cbxMembresia.SelectedValue);
                    entMembresia Memb = logMembresia.Instancia.BuscarMembresiaID(idMembresia);
                    if (Memb != null && (Memb.estMembresia = true))
                    {
                        lblIDMemb.Text = Convert.ToString(Memb.idMembresia);
                        txtDuracion.Text = Convert.ToString(Memb.duracion);
                        txtPrecio.Text = Convert.ToString(Memb.precio);
                    }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            entVentaMem Vmeb = new entVentaMem();
            entMembresia Memb = new entMembresia();

            if ((lblIDMemb.Text.Trim() != "") && (txtComent.Text.Trim() != "") && (txbDNI_Cliente.Text.Trim() != ""))
            {
                if (confilas == 0)
                {
                        dtgVentaServicios.Rows.Add(txbDNI_Cliente.Text, txbNombreCliente.Text, lblIDMemb.Text, cbxMembresia.Text, txtDuracion.Text, txtPrecio.Text, cmbPromocionM.Text, txtMontoTotal.Text,cbEstadoVM.Checked);
                        decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocionM.SelectedValue));
                        decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaServicios.Rows[confilas].Cells[5].Value), descuento);
                        dtgVentaServicios.Rows[confilas].Cells[7].Value = precioDescuento;
                        confilas++;
                }
                else
                {
                    dtgVentaServicios.Rows.Add(txbDNI_Cliente.Text, txbNombreCliente.Text, lblIDMemb.Text, cbxMembresia.Text, txtDuracion.Text, txtPrecio.Text, cmbPromocionM.Text, txtMontoTotal.Text, cbEstadoVM.Checked);
                    decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocionM.SelectedValue));
                    decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaServicios.Rows[confilas].Cells[5].Value), descuento);
                    dtgVentaServicios.Rows[confilas].Cells[7].Value = precioDescuento;
                    confilas++;
                }
                MontoPagar = 0;
                foreach (DataGridViewRow Fila in dtgVentaServicios.Rows)
                {
                    MontoPagar += Convert.ToDecimal(Fila.Cells[7].Value);
                }
                txtMontoTotal.Text = MontoPagar.ToString();
            }
        }

        private void txbNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertarVMem_Click(object sender, EventArgs e)
        {
            try
            {
                entVentaMem membresia = new entVentaMem();

                membresia.UsuarioID = 1;
                membresia.ClienteID = Convert.ToInt32(txbDNI_Cliente.Text);
                membresia.MetododepagoID = Convert.ToInt32(cbxMetodo.SelectedValue);
                membresia.FormadepagoID = Convert.ToInt32(cbxForma.SelectedValue);
                membresia.MembresiaID = Convert.ToInt32(cbxMembresia.SelectedValue);
                membresia.PromocionID = Convert.ToInt32(cmbPromocionM.SelectedValue);
                membresia.FechaVenMemb = FechaVentaMemb.Value;
                membresia.MontoVenMemb = Convert.ToDecimal(txtMontoTotal.Text);
                membresia.Comentario = txtComent.Text;
                membresia.estVentaMemb = true;

                int idVenMemb = logVentaMem.Instancia.InsertarVentaMem(membresia);

                MessageBox.Show("Se guardó correctamente la Venta de la Membresía");
                LimpiarVariables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsultarVentas_Click_1(object sender, EventArgs e)
        {
                        CSLT_Venta_Membresía mainForm = new CSLT_Venta_Membresía();
            mainForm.Show();
        }
    }
}
