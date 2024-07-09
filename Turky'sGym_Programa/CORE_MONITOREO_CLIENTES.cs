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
    public partial class CORE_MONITOREO_CLIENTES : Form
    {
        private Boolean genero; // false = femenino, true = masculino
        public CORE_MONITOREO_CLIENTES()
        {
            InitializeComponent();
            btnAnular.Enabled = false;
            btnBuscarMonitoreo.Enabled = false;
            btnInsertarFichaM.Enabled = false;
            btnLimpiarTM.Enabled = false;
            listarFichaM();
        }
        public void listarFichaM()
        {
            dgvMonitoreoClientes.DataSource = logRelFichaM.Instancia.ListarFichaM();
            // Ocultar la columna AdminID si existe
            if (dgvMonitoreoClientes.Columns["UsuarioID"] != null)
            {
                dgvMonitoreoClientes.Columns["UsuarioID"].Visible = false;
            }
        }
        public void LimpiarVariables()
        {
            lblFichamonitoreoID.Text = "00";
            txbDNImonitoreo.Text = string.Empty;
            chkFemenino.Checked = false;
            chkMasculino.Checked = false;
            genero = false;
            txbNombreClienteM.Text = string.Empty;
            txtObjetivo.Text = string.Empty;
            dtpFechaEvaluacion.Value = DateTime.Now;
            dtpProximoMonitoreo.Value = DateTime.Now;
            txtEdadClienteM.Text = string.Empty;
            txbTalla.Text = string.Empty;
            lblIMC.Text = "00";
            txbGrasa.Text = string.Empty;
            txbHidratacion.Text = string.Empty;
            txbPeso.Text = string.Empty;
            txbMasaM.Text = string.Empty;
            txbMasaO.Text = string.Empty;
            txbKCal.Text = string.Empty;
            TXBbRAZOS.Text = string.Empty;
            txbPecho.Text = string.Empty;
            txtCintura.Text = string.Empty;
            txbCadera.Text = string.Empty;
            txbCuadriceps.Text = string.Empty;
            txbPantorilla.Text = string.Empty;
        }
        private void CORE_MONITOREO_CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void txbDNImonitoreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txbCuadriceps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCadera_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCintura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txbPecho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txbPantorilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBbRAZOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarMonitoreo_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBusCliFichaM_Click(object sender, EventArgs e)
        {
            txbDNImonitoreo.Focus();

            // Verificar si el texto en txbDNImonitoreo es un número válido
            if (!int.TryParse(txbDNImonitoreo.Text, out int ClienteID))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el cliente
            entCliente cl = logCliente.Instancia.BuscarClienteID(ClienteID);

            if (cl != null && cl.ClienteID != 0)
            {
                txbDNImonitoreo.Text = cl.ClienteID.ToString();
                txbNombreClienteM.Text = cl.NomCliente;
                btnAnular.Enabled = true;
                btnBuscarMonitoreo.Enabled = true;
                btnInsertarFichaM.Enabled = true;
                btnLimpiarTM.Enabled = true;
            }
            else
            {
                MessageBox.Show("El cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbDNImonitoreo.Text = "";
                txbNombreClienteM.Text = "";
            }
        }

        private void btnBuscarMonitoreo_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(txbDNImonitoreo.Text, out int clienteID))
            {
                dgvMonitoreoClientes.DataSource = logRelFichaM.Instancia.ListarFichaMPorCliente(clienteID);
            }
            else if (string.IsNullOrWhiteSpace(txbDNImonitoreo.Text))
            {
                // Si el TextBox está vacío, muestra todos los registros
                dgvMonitoreoClientes.DataSource = logRelFichaM.Instancia.ListarFichaM();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
            }
        }

        private void btnInsertarFichaM_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvMonitoreoClientes.CurrentRow != null)
            {
                DataGridViewRow filaActual = dgvMonitoreoClientes.CurrentRow;

                // Asegúrate de que los índices de las celdas correspondan a tu DataGridView
                lblFichamonitoreoID.Text = filaActual.Cells["FichamonitoreoID"].Value?.ToString() ?? "";
                txtObjetivo.Text = filaActual.Cells["ObjetivoPer"].Value?.ToString() ?? "";

                if (DateTime.TryParse(filaActual.Cells["FechaEva"].Value?.ToString(), out DateTime fechaEva))
                    dtpFechaEvaluacion.Value = fechaEva;

                if (DateTime.TryParse(filaActual.Cells["ProxCita"].Value?.ToString(), out DateTime proxCita))
                    dtpProximoMonitoreo.Value = proxCita;

                // Obtener el género desde la celda correspondiente
                bool genero = Convert.ToBoolean(filaActual.Cells["Genero"].Value);
                // Asumiendo que tienes dos checkboxes: chkMasculino y chkFemenino
                chkMasculino.Checked = genero;
                chkFemenino.Checked = !genero;

                txtEdadClienteM.Text = filaActual.Cells["Edad"].Value?.ToString() ?? "";
                txbTalla.Text = filaActual.Cells["Talla"].Value?.ToString() ?? "";
                lblIMC.Text = filaActual.Cells["IMC"].Value?.ToString() ?? "";
                txbGrasa.Text = filaActual.Cells["Grasa"].Value?.ToString() ?? "";
                txbHidratacion.Text = filaActual.Cells["Hidratacion"].Value?.ToString() ?? "";
                txbPeso.Text = filaActual.Cells["Peso"].Value?.ToString() ?? "";
                txbMasaM.Text = filaActual.Cells["M_muscular"].Value?.ToString() ?? "";
                txbMasaO.Text = filaActual.Cells["M_osea"].Value?.ToString() ?? "";
                txbKCal.Text = filaActual.Cells["K_cal"].Value?.ToString() ?? "";
                TXBbRAZOS.Text = filaActual.Cells["Brazos"].Value?.ToString() ?? "";
                txbPecho.Text = filaActual.Cells["Pecho"].Value?.ToString() ?? "";
                txtCintura.Text = filaActual.Cells["Cintura"].Value?.ToString() ?? "";
                txbCadera.Text = filaActual.Cells["Cadera"].Value?.ToString() ?? "";
                txbCuadriceps.Text = filaActual.Cells["Cuadriceps"].Value?.ToString() ?? "";
                txbPantorilla.Text = filaActual.Cells["Pantorrilla"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertIMC_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los TextBoxes y convertirlos a números decimales
            if (decimal.TryParse(txbPeso.Text.Trim(), out decimal peso) &&
                decimal.TryParse(txbTalla.Text.Trim(), out decimal talla))
            {
                // Calcular el IMC
                decimal imc = peso / (talla * talla);

                // Mostrar el resultado en el Label
                lblIMC.Text = $"{imc:F2}"; // Muestra el IMC con dos decimales
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores válidos para peso y talla.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbTalla.Text.Trim(), out decimal talla))
            {
                string tallaString = talla.ToString("F2");
                string[] parts = tallaString.Split('.');

                if (parts.Length > 1)
                {
                    if (int.TryParse(parts[1], out int parteDecimal))
                    {
                        int decimalMas3 = parteDecimal + 3;
                        int decimalMenos3 = parteDecimal - 3;

                        // Mostrar el rango en el Label
                        label27.Text = $"Rango: {decimalMenos3} - {decimalMas3}";
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener la parte decimal.");
                    }
                }
                else
                {
                    MessageBox.Show("La talla no tiene parte decimal.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce una talla válida.");
            }
        }

        private void dgvMonitoreoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvMonitoreoClientes.Rows[e.RowIndex];
            lblFichamonitoreoID.Text = filaActual.Cells[0].Value.ToString();
            txtObjetivo.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaEvaluacion.Value = Convert.ToDateTime(filaActual.Cells[4].Value);
            dtpProximoMonitoreo.Value = Convert.ToDateTime(filaActual.Cells[5].Value);

            // Obtener el género
            bool genero = Convert.ToBoolean(filaActual.Cells[6].Value);
            // Asumiendo que tienes dos checkboxes: chkMasculino y chkFemenino
            chkMasculino.Checked = genero;
            chkFemenino.Checked = !genero;

            txtEdadClienteM.Text = filaActual.Cells[7].Value.ToString();
            txbTalla.Text = filaActual.Cells[8].Value.ToString();
            lblIMC.Text = filaActual.Cells[9].Value.ToString();
            txbGrasa.Text = filaActual.Cells[10].Value.ToString();
            txbHidratacion.Text = filaActual.Cells[11].Value.ToString();
            txbPeso.Text = filaActual.Cells[12].Value.ToString();
            txbMasaM.Text = filaActual.Cells[13].Value.ToString();
            txbMasaO.Text = filaActual.Cells[14].Value.ToString();
            txbKCal.Text = filaActual.Cells[15].Value.ToString();
            TXBbRAZOS.Text = filaActual.Cells[16].Value.ToString();
            txbPecho.Text = filaActual.Cells[17].Value.ToString();
            txtCintura.Text = filaActual.Cells[18].Value.ToString();
            txbCadera.Text = filaActual.Cells[19].Value.ToString();
            txbCuadriceps.Text = filaActual.Cells[20].Value.ToString();
            txbPantorilla.Text = filaActual.Cells[21].Value.ToString();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblFichamonitoreoID.Text, out int fichamonitoreoID))
            {
                logRelFichaM.Instancia.EliminarFichaM(fichamonitoreoID);
                listarFichaM();
                LimpiarVariables();
            }
            else
            {
                MessageBox.Show("El ID de Ficha Monitoreo no es válido.");
            }
        }

        private void btnLimpiarTM_Click(object sender, EventArgs e)
        {

            btnAnular.Enabled = false;
            btnBuscarMonitoreo.Enabled = false;
            btnInsertarFichaM.Enabled = false;
            btnLimpiarTM.Enabled = false;
            LimpiarVariables();
            listarFichaM();
        }

        private void chkFemenino_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasculino.Checked)
            {
                chkFemenino.Checked = false;
                genero = false;
            }
        }

        private void chkFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemenino.Checked)
            {
                chkMasculino.Checked = false;
                genero = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (!chkFemenino.Checked && !chkMasculino.Checked)
                {
                    MessageBox.Show("Por favor, seleccione un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                entRelFichaM fm = new entRelFichaM();

                // Asignar valores a las propiedades de fichaMonitoreo
                fm.ObjetivoPer = txtObjetivo.Text.Trim();
                fm.FechaEva = dtpFechaEvaluacion.Value;
                fm.ProxCita = dtpProximoMonitoreo.Value;
                fm.Genero = genero;
                fm.Edad = Convert.ToInt32(txtEdadClienteM.Text);
                fm.Talla = Convert.ToDecimal(txbTalla.Text);
                fm.IMC = Convert.ToDecimal(lblIMC.Text);
                fm.Grasa = Convert.ToDecimal(txbGrasa.Text);
                fm.Hidratacion = Convert.ToDecimal(txbHidratacion.Text);
                fm.Peso = Convert.ToDecimal(txbPeso.Text);
                fm.M_muscular = Convert.ToDecimal(txbMasaM.Text);
                fm.M_osea = Convert.ToDecimal(txbMasaO.Text);
                fm.K_cal = Convert.ToInt32(txbKCal.Text);
                fm.Brazos = Convert.ToDecimal(TXBbRAZOS.Text);
                fm.Pecho = Convert.ToDecimal(txbPecho.Text);
                fm.Cintura = Convert.ToDecimal(txtCintura.Text);
                fm.Cadera = Convert.ToDecimal(txbCadera.Text);
                fm.Cuadriceps = Convert.ToDecimal(txbCuadriceps.Text);
                fm.Pantorrilla = Convert.ToDecimal(txbPantorilla.Text);

                // Llamar al método para insertar la ficha de monitoreo
                logRelFichaM.Instancia.InsertarFichaM(fm);

                MessageBox.Show("Ficha de monitoreo insertada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y actualizar
                LimpiarVariables();
                listarFichaM();
                btnAnular.Enabled = false;
                btnBuscarMonitoreo.Enabled = false;
                btnInsertarFichaM.Enabled = false;
                btnLimpiarTM.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la ficha de monitoreo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
