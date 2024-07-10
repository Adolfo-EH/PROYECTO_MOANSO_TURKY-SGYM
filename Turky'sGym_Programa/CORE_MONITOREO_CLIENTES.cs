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
        
        public CORE_MONITOREO_CLIENTES()
        {
            InitializeComponent();
            btnBuscarMonitoreo.Enabled = false;
            btnInsertarFichaM.Enabled = false;
            btnLimpiarTM.Enabled = false;
            listarFichaM();
        }
        public void listarFichaM()
        {
            dgvMonitoreoClientes.DataSource = logRelFichaM.Instancia.ListarFichaM();
            dgvMonitoreoClientes.Columns["UsuarioID"].Visible = false;
            dgvMonitoreoClientes.Columns["K_cal"].Visible = false;
        }
        public void LimpiarVariables()
        {
            lblFichamonitoreoID.Text = "00";
            txbDNImonitoreo.Text = string.Empty;
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
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CORE_MONITOREO_CLIENTES_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
            cmbGenero.DataSource = logRelFichaM.Instancia.CargarGenero();
            cmbGenero.DisplayMember = "NomGenero";
            cmbGenero.ValueMember = "GeneroID";
            txbKCal.Enabled = false;
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

                lblFichamonitoreoID.Text = filaActual.Cells["FichamonitoreoID"].Value?.ToString() ?? "";
                cmbGenero.SelectedValue = filaActual.Cells["GeneroID"].Value;
                txtObjetivo.Text = filaActual.Cells["ObjetivoPer"].Value?.ToString() ?? "";

                if (DateTime.TryParse(filaActual.Cells["FechaEva"].Value?.ToString(), out DateTime fechaEva))
                    dtpFechaEvaluacion.Value = fechaEva;

                if (DateTime.TryParse(filaActual.Cells["ProxCita"].Value?.ToString(), out DateTime proxCita))
                    dtpProximoMonitoreo.Value = proxCita;



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
            if (decimal.TryParse(txbPeso.Text.Trim(), out decimal peso) &&
        decimal.TryParse(txbTalla.Text.Trim(), out decimal talla))
            {
                // Calcular el IMC
                decimal imc = peso / (talla * talla);

                // Mostrar el resultado decimal en lblIMC
                lblIMC.Text = $"{imc:F2}";

                // Determinar el estado de salud
                string estadoSalud = DeterminarEstadoSalud(imc);

                // Mostrar el estado de salud en lblestIMC
                estIMC.Text = $"Estado: {estadoSalud}";

            }
            else
            {
                MessageBox.Show("Por favor, introduce valores válidos para peso y talla.");
            }
        }

        private string DeterminarEstadoSalud(decimal imc)
        {
            if (imc < 18.5m)
                return "Bajo de peso";
            else if (imc < 25m)
                return "Peso normal";
            else if (imc < 30m)
                return "Sobrepeso";
            else if (imc < 35m)
                return "Obesidad ligera";
            else if (imc < 40m)
                return "Obesidad";
            else
                return "Obesidad mórbida o grave";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbTalla.Text.Trim(), out decimal talla) &&
        decimal.TryParse(txbPeso.Text.Trim(), out decimal peso) &&
        int.TryParse(txtEdadClienteM.Text.Trim(), out int edad))
            {
                int generoID = Convert.ToInt32(cmbGenero.SelectedValue);
                bool esMasculino = (generoID == 2);

                // Calcular IMC
                decimal imc = peso / (talla * talla);

                // Calcular peso ideal
                (decimal pesoIdealMin, decimal pesoIdealMax) = ObtenerRangoPesoIdeal(talla, esMasculino);

                // Calcular porcentaje de grasa corporal ideal
                decimal grasaCorporalIdealMin = ObtenerPorcentajeGrasaIdealMin(edad, esMasculino);
                decimal grasaCorporalIdealMax = ObtenerPorcentajeGrasaIdealMax(edad, esMasculino);

                // Calcular hidratación ideal
                decimal hidratacionIdealMin = esMasculino ? 50m : 45m;
                decimal hidratacionIdealMax = esMasculino ? 65m : 50m;

                // Calcular K.cal ideal
                int kcalIdealMin = ObtenerKCalIdealMin(edad, esMasculino);
                int kcalIdealMax = ObtenerKCalIdealMax(edad, esMasculino);

                // Calcular masa muscular ideal
                decimal masaMuscularIdealMin = ObtenerMasaMuscularIdealMin(edad, esMasculino);
                decimal masaMuscularIdealMax = ObtenerMasaMuscularIdealMax(edad, esMasculino);

                // Mostrar resultados
                label27.Text = $"Peso Ideal: {pesoIdealMin:F1} - {pesoIdealMax:F1} kg";
                label23.Text = $"Ideal: {grasaCorporalIdealMin:F1} - {grasaCorporalIdealMax:F1}%";
                label28.Text = $"Ideal: {hidratacionIdealMin:F1} - {hidratacionIdealMax:F1}%";
                label24.Text = $"Ideal: {kcalIdealMin} - {kcalIdealMax}";
                label26.Text = $"Ideal: {masaMuscularIdealMin:F1} - {masaMuscularIdealMax:F1}%";
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores válidos para peso, talla y edad.");
            }
        }

        private void dgvMonitoreoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMonitoreoClientes.Rows[e.RowIndex];
            lblFichamonitoreoID.Text = filaActual.Cells[0].Value.ToString();
            cmbGenero.SelectedValue = filaActual.Cells[3].Value?.ToString() ?? string.Empty;
            txtObjetivo.Text = filaActual.Cells[4].Value.ToString();
            dtpFechaEvaluacion.Value = Convert.ToDateTime(filaActual.Cells[5].Value);
            dtpProximoMonitoreo.Value = Convert.ToDateTime(filaActual.Cells[6].Value);
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
        }

        private void chkFemenino_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entRelFichaM fm = new entRelFichaM();

                if (!int.TryParse(txbDNImonitoreo.Text, out int clienteID))
                    throw new ArgumentException("DNI del cliente no válido.");
                fm.ClienteID = clienteID;
                fm.UsuarioID = 1;

                if (cmbGenero.SelectedValue == null)
                    throw new ArgumentException("Seleccione un género.");
                fm.GeneroID = Convert.ToInt32(cmbGenero.SelectedValue);

                fm.ObjetivoPer = txtObjetivo.Text.Trim();
                fm.FechaEva = dtpFechaEvaluacion.Value;
                fm.ProxCita = dtpProximoMonitoreo.Value;

                if (!int.TryParse(txtEdadClienteM.Text, out int edad))
                    throw new ArgumentException("Edad no válida.");
                fm.Edad = edad;

                if (!decimal.TryParse(txbTalla.Text, out decimal talla))
                    throw new ArgumentException("Talla no válida.");
                fm.Talla = talla;

                
                fm.IMC = ValidarDecimal(lblIMC.Text, "IMC");
                fm.Grasa = ValidarDecimal(txbGrasa.Text, "Grasa");
                fm.Hidratacion = ValidarDecimal(txbHidratacion.Text, "Hidratación");
                fm.Peso = ValidarDecimal(txbPeso.Text, "Peso");
                fm.M_muscular = ValidarDecimal(txbMasaM.Text, "Masa muscular");
                fm.M_osea = ValidarDecimal(txbMasaO.Text, "Masa ósea");
                fm.K_cal = 2.00m;
                fm.Brazos = ValidarDecimal(TXBbRAZOS.Text, "Brazos");
                fm.Pecho = ValidarDecimal(txbPecho.Text, "Pecho");
                fm.Cintura = ValidarDecimal(txtCintura.Text, "Cintura");
                fm.Cadera = ValidarDecimal(txbCadera.Text, "Cadera");
                fm.Cuadriceps = ValidarDecimal(txbCuadriceps.Text, "Cuádriceps");
                fm.Pantorrilla = ValidarDecimal(txbPantorilla.Text, "Pantorrilla");

                logRelFichaM.Instancia.InsertarFichaM(fm);
                MessageBox.Show("Ficha de monitoreo insertada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarVariables();
                listarFichaM();
                btnBuscarMonitoreo.Enabled = btnInsertarFichaM.Enabled = btnLimpiarTM.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de alteracion de datos existentes: {ex.Message}", "Error de alteracion de datos existentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ValidarDecimal(string valor, string campo)
        {
            if (!decimal.TryParse(valor, out decimal resultado))
                throw new ArgumentException($"{campo} no válido.");
            return resultado;
        }

        private (decimal min, decimal max) ObtenerRangoPesoIdeal(decimal talla, bool esMasculino)
        {
            decimal pesoIdealBase;
            if (esMasculino)
            {
                pesoIdealBase = talla * 100 - 100;
            }
            else
            {
                pesoIdealBase = (talla * 100 - 100) * 0.9m;
            }

            decimal pesoIdealMin = Math.Round(pesoIdealBase - 2.5m, 1);
            decimal pesoIdealMax = Math.Round(pesoIdealBase + 2.5m, 1);

            return (pesoIdealMin, pesoIdealMax);
        }

        private decimal ObtenerPorcentajeGrasaIdealMin(int edad, bool esMasculino)
        {
            if (esMasculino)
            {
                if (edad >= 15 && edad <= 20) return 15m;
                if (edad >= 21 && edad <= 25) return 16;
                if (edad >= 26 && edad <= 30) return 19m;
                if (edad >= 31 && edad <= 35) return 20m;
                if (edad >= 36 && edad <= 45) return 21m;
                if (edad >= 46 && edad <= 50) return 22m;
                if (edad >= 51 && edad <= 60) return 23m;
                return 24;
            }
            else
            {
                if (edad >= 15 && edad <= 20) return 18m;
                if (edad >= 21 && edad <= 25) return 21;
                if (edad >= 26 && edad <= 30) return 22m;
                if (edad >= 31 && edad <= 35) return 24m;
                if (edad >= 36 && edad <= 45) return 25m;
                if (edad >= 46 && edad <= 50) return 28m;
                if (edad >= 51 && edad <= 60) return 29m;
                return 29m;
            }
        }

        private decimal ObtenerPorcentajeGrasaIdealMax(int edad, bool esMasculino)
        {
            if (esMasculino)
            {
                if (edad >= 15 && edad <= 20) return 18m;
                if (edad >= 21 && edad <= 25) return 20m;
                if (edad >= 26 && edad <= 30) return 21m;
                if (edad >= 31 && edad <= 35) return 21m;
                if (edad >= 36 && edad <= 45) return 23m;
                if (edad >= 46 && edad <= 50) return 23m;
                if (edad >= 51 && edad <= 60) return 24m;
                return 25m;
            }
            else
            {
                if (edad >= 15 && edad <= 20) return 22m;
                if (edad >= 21 && edad <= 25) return 23m;
                if (edad >= 26 && edad <= 30) return 24m;
                if (edad >= 31 && edad <= 35) return 26m;
                if (edad >= 36 && edad <= 45) return 27m;
                if (edad >= 46 && edad <= 50) return 30m;
                if (edad >= 51 && edad <= 60) return 31m;
                return 31m;
            }
        }

        private int ObtenerKCalIdealMin(int edad, bool esMasculino)
        {

            if (esMasculino)
            {
                if (edad >= 2 && edad <= 6) return 1000;
                if (edad >= 7 && edad <= 18) return 1600;
                if (edad >= 19 && edad <= 60) return 2400;
                return 2200;
            }
            else
            {
                if (edad >= 2 && edad <= 6) return 1000;
                if (edad >= 7 && edad <= 18) return 1600;
                if (edad >= 19 && edad <= 60) return 1800;
                return 1800;
            }
        }

        private int ObtenerKCalIdealMax(int edad, bool esMasculino)
        {

            if (esMasculino)
            {
                if (edad >= 2 && edad <= 6) return 1800;
                if (edad >= 7 && edad <= 18) return 3200;
                if (edad >= 19 && edad <= 60) return 3000;
                return 2600;
            }
            else
            {
                if (edad >= 2 && edad <= 6) return 1600;
                if (edad >= 7 && edad <= 18) return 2400;
                if (edad >= 19 && edad <= 60) return 2400;
                return 2000;
            }
        }

        private decimal ObtenerMasaMuscularIdealMin(int edad, bool esMasculino)
        {

            if (esMasculino)
            {
                if (edad < 30) return 37m;
                if (edad >= 30 && edad < 40) return 35m;
                if (edad >= 40 && edad < 50) return 33m;
                if (edad >= 50 && edad < 60) return 31m;
                return 29m;
            }
            else
            {
                if (edad < 30) return 31m;
                if (edad < 40) return 30m;
                if (edad < 50) return 29m;
                if (edad < 60) return 28m;
                return 27m;
            }
        }

        private decimal ObtenerMasaMuscularIdealMax(int edad, bool esMasculino)
        {

            if (esMasculino)
            {
                if (edad < 30) return 43m;
                if (edad < 40) return 41m;
                if (edad < 50) return 39m;
                if (edad < 60) return 36m;
                return 34m;
            }
            else
            {
                if (edad < 30) return 36m;
                if (edad < 40) return 34m;
                if (edad < 50) return 33m;
                if (edad < 60) return 32m;
                return 31m;
            }
        }
    }
}
