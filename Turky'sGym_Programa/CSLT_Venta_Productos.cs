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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProductoCSLTVenta = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaCSLTVenta = new System.Windows.Forms.ComboBox();
            this.cmbMarcaCSLTVenta = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPagoCSLTVenta = new System.Windows.Forms.ComboBox();
            this.ckbEstadoCSLTVenta = new System.Windows.Forms.CheckBox();
            this.lblCategoriaCSLTVenta = new System.Windows.Forms.Label();
            this.btnBuscarCSLTVenta = new System.Windows.Forms.Button();
            this.lblFechaCSLTVenta = new System.Windows.Forms.Label();
            this.lblMetodoPagoCSLTVenta = new System.Windows.Forms.Label();
            this.dtpFechaCSLTVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIDDetalleCSLTVenta = new System.Windows.Forms.TextBox();
            this.lblDetalleCSLTVenta = new System.Windows.Forms.Label();
            this.lblEstadoCSLTVenta = new System.Windows.Forms.Label();
            this.txtIDVentaCSLTVenta = new System.Windows.Forms.TextBox();
            this.lblVentaCSLTVenta = new System.Windows.Forms.Label();
            this.lblProductoCSLTVenta = new System.Windows.Forms.Label();
            this.lblMarcaCSLTVenta = new System.Windows.Forms.Label();
            this.btnRegresarCSLTVenta = new System.Windows.Forms.Button();
            this.dgvCSLTVenta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSLTVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProductoCSLTVenta);
            this.groupBox1.Controls.Add(this.cmbCategoriaCSLTVenta);
            this.groupBox1.Controls.Add(this.cmbMarcaCSLTVenta);
            this.groupBox1.Controls.Add(this.cmbMetodoPagoCSLTVenta);
            this.groupBox1.Controls.Add(this.ckbEstadoCSLTVenta);
            this.groupBox1.Controls.Add(this.lblCategoriaCSLTVenta);
            this.groupBox1.Controls.Add(this.btnBuscarCSLTVenta);
            this.groupBox1.Controls.Add(this.lblFechaCSLTVenta);
            this.groupBox1.Controls.Add(this.lblMetodoPagoCSLTVenta);
            this.groupBox1.Controls.Add(this.dtpFechaCSLTVenta);
            this.groupBox1.Controls.Add(this.txtIDDetalleCSLTVenta);
            this.groupBox1.Controls.Add(this.lblDetalleCSLTVenta);
            this.groupBox1.Controls.Add(this.lblEstadoCSLTVenta);
            this.groupBox1.Controls.Add(this.txtIDVentaCSLTVenta);
            this.groupBox1.Controls.Add(this.lblVentaCSLTVenta);
            this.groupBox1.Controls.Add(this.lblProductoCSLTVenta);
            this.groupBox1.Controls.Add(this.lblMarcaCSLTVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(338, 263);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llena filtros para la búsqueda:";
            // 
            // cmbProductoCSLTVenta
            // 
            this.cmbProductoCSLTVenta.FormattingEnabled = true;
            this.cmbProductoCSLTVenta.Location = new System.Drawing.Point(8, 185);
            this.cmbProductoCSLTVenta.Name = "cmbProductoCSLTVenta";
            this.cmbProductoCSLTVenta.Size = new System.Drawing.Size(146, 25);
            this.cmbProductoCSLTVenta.TabIndex = 55;
            // 
            // cmbCategoriaCSLTVenta
            // 
            this.cmbCategoriaCSLTVenta.FormattingEnabled = true;
            this.cmbCategoriaCSLTVenta.Location = new System.Drawing.Point(176, 98);
            this.cmbCategoriaCSLTVenta.Name = "cmbCategoriaCSLTVenta";
            this.cmbCategoriaCSLTVenta.Size = new System.Drawing.Size(146, 25);
            this.cmbCategoriaCSLTVenta.TabIndex = 54;
            // 
            // cmbMarcaCSLTVenta
            // 
            this.cmbMarcaCSLTVenta.FormattingEnabled = true;
            this.cmbMarcaCSLTVenta.Location = new System.Drawing.Point(176, 141);
            this.cmbMarcaCSLTVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarcaCSLTVenta.Name = "cmbMarcaCSLTVenta";
            this.cmbMarcaCSLTVenta.Size = new System.Drawing.Size(146, 25);
            this.cmbMarcaCSLTVenta.TabIndex = 38;
            // 
            // cmbMetodoPagoCSLTVenta
            // 
            this.cmbMetodoPagoCSLTVenta.FormattingEnabled = true;
            this.cmbMetodoPagoCSLTVenta.Location = new System.Drawing.Point(176, 185);
            this.cmbMetodoPagoCSLTVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMetodoPagoCSLTVenta.Name = "cmbMetodoPagoCSLTVenta";
            this.cmbMetodoPagoCSLTVenta.Size = new System.Drawing.Size(146, 25);
            this.cmbMetodoPagoCSLTVenta.TabIndex = 23;
            // 
            // ckbEstadoCSLTVenta
            // 
            this.ckbEstadoCSLTVenta.AutoSize = true;
            this.ckbEstadoCSLTVenta.Location = new System.Drawing.Point(17, 48);
            this.ckbEstadoCSLTVenta.Margin = new System.Windows.Forms.Padding(2);
            this.ckbEstadoCSLTVenta.Name = "ckbEstadoCSLTVenta";
            this.ckbEstadoCSLTVenta.Size = new System.Drawing.Size(73, 22);
            this.ckbEstadoCSLTVenta.TabIndex = 37;
            this.ckbEstadoCSLTVenta.Text = "Activo";
            this.ckbEstadoCSLTVenta.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaCSLTVenta
            // 
            this.lblCategoriaCSLTVenta.AutoSize = true;
            this.lblCategoriaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCSLTVenta.Location = new System.Drawing.Point(169, 79);
            this.lblCategoriaCSLTVenta.Name = "lblCategoriaCSLTVenta";
            this.lblCategoriaCSLTVenta.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaCSLTVenta.TabIndex = 35;
            this.lblCategoriaCSLTVenta.Text = "Categoria";
            // 
            // btnBuscarCSLTVenta
            // 
            this.btnBuscarCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCSLTVenta.Location = new System.Drawing.Point(110, 224);
            this.btnBuscarCSLTVenta.Name = "btnBuscarCSLTVenta";
            this.btnBuscarCSLTVenta.Size = new System.Drawing.Size(94, 33);
            this.btnBuscarCSLTVenta.TabIndex = 18;
            this.btnBuscarCSLTVenta.Text = "Buscar";
            this.btnBuscarCSLTVenta.UseVisualStyleBackColor = true;
            // 
            // lblFechaCSLTVenta
            // 
            this.lblFechaCSLTVenta.AutoSize = true;
            this.lblFechaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCSLTVenta.Location = new System.Drawing.Point(107, 29);
            this.lblFechaCSLTVenta.Name = "lblFechaCSLTVenta";
            this.lblFechaCSLTVenta.Size = new System.Drawing.Size(105, 16);
            this.lblFechaCSLTVenta.TabIndex = 17;
            this.lblFechaCSLTVenta.Text = "Fecha de Venta:";
            // 
            // lblMetodoPagoCSLTVenta
            // 
            this.lblMetodoPagoCSLTVenta.AutoSize = true;
            this.lblMetodoPagoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPagoCSLTVenta.Location = new System.Drawing.Point(169, 167);
            this.lblMetodoPagoCSLTVenta.Name = "lblMetodoPagoCSLTVenta";
            this.lblMetodoPagoCSLTVenta.Size = new System.Drawing.Size(89, 16);
            this.lblMetodoPagoCSLTVenta.TabIndex = 31;
            this.lblMetodoPagoCSLTVenta.Text = "Método Pago";
            // 
            // dtpFechaCSLTVenta
            // 
            this.dtpFechaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCSLTVenta.Location = new System.Drawing.Point(110, 46);
            this.dtpFechaCSLTVenta.Name = "dtpFechaCSLTVenta";
            this.dtpFechaCSLTVenta.Size = new System.Drawing.Size(212, 22);
            this.dtpFechaCSLTVenta.TabIndex = 16;
            // 
            // txtIDDetalleCSLTVenta
            // 
            this.txtIDDetalleCSLTVenta.Location = new System.Drawing.Point(8, 98);
            this.txtIDDetalleCSLTVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDetalleCSLTVenta.Name = "txtIDDetalleCSLTVenta";
            this.txtIDDetalleCSLTVenta.Size = new System.Drawing.Size(146, 24);
            this.txtIDDetalleCSLTVenta.TabIndex = 30;
            // 
            // lblDetalleCSLTVenta
            // 
            this.lblDetalleCSLTVenta.AutoSize = true;
            this.lblDetalleCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCSLTVenta.Location = new System.Drawing.Point(5, 79);
            this.lblDetalleCSLTVenta.Name = "lblDetalleCSLTVenta";
            this.lblDetalleCSLTVenta.Size = new System.Drawing.Size(104, 16);
            this.lblDetalleCSLTVenta.TabIndex = 29;
            this.lblDetalleCSLTVenta.Text = "ID Detalle Venta";
            // 
            // lblEstadoCSLTVenta
            // 
            this.lblEstadoCSLTVenta.AutoSize = true;
            this.lblEstadoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCSLTVenta.Location = new System.Drawing.Point(5, 29);
            this.lblEstadoCSLTVenta.Name = "lblEstadoCSLTVenta";
            this.lblEstadoCSLTVenta.Size = new System.Drawing.Size(50, 16);
            this.lblEstadoCSLTVenta.TabIndex = 28;
            this.lblEstadoCSLTVenta.Text = "Estado";
            // 
            // txtIDVentaCSLTVenta
            // 
            this.txtIDVentaCSLTVenta.Location = new System.Drawing.Point(8, 141);
            this.txtIDVentaCSLTVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDVentaCSLTVenta.Name = "txtIDVentaCSLTVenta";
            this.txtIDVentaCSLTVenta.Size = new System.Drawing.Size(146, 24);
            this.txtIDVentaCSLTVenta.TabIndex = 26;
            // 
            // lblVentaCSLTVenta
            // 
            this.lblVentaCSLTVenta.AutoSize = true;
            this.lblVentaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaCSLTVenta.Location = new System.Drawing.Point(5, 123);
            this.lblVentaCSLTVenta.Name = "lblVentaCSLTVenta";
            this.lblVentaCSLTVenta.Size = new System.Drawing.Size(134, 16);
            this.lblVentaCSLTVenta.TabIndex = 25;
            this.lblVentaCSLTVenta.Text = "ID Venta de Producto";
            // 
            // lblProductoCSLTVenta
            // 
            this.lblProductoCSLTVenta.AutoSize = true;
            this.lblProductoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoCSLTVenta.Location = new System.Drawing.Point(5, 167);
            this.lblProductoCSLTVenta.Name = "lblProductoCSLTVenta";
            this.lblProductoCSLTVenta.Size = new System.Drawing.Size(61, 16);
            this.lblProductoCSLTVenta.TabIndex = 22;
            this.lblProductoCSLTVenta.Text = "Producto";
            // 
            // lblMarcaCSLTVenta
            // 
            this.lblMarcaCSLTVenta.AutoSize = true;
            this.lblMarcaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaCSLTVenta.Location = new System.Drawing.Point(169, 123);
            this.lblMarcaCSLTVenta.Name = "lblMarcaCSLTVenta";
            this.lblMarcaCSLTVenta.Size = new System.Drawing.Size(45, 16);
            this.lblMarcaCSLTVenta.TabIndex = 19;
            this.lblMarcaCSLTVenta.Text = "Marca";
            // 
            // btnRegresarCSLTVenta
            // 
            this.btnRegresarCSLTVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresarCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCSLTVenta.Location = new System.Drawing.Point(7, 359);
            this.btnRegresarCSLTVenta.Name = "btnRegresarCSLTVenta";
            this.btnRegresarCSLTVenta.Size = new System.Drawing.Size(1022, 33);
            this.btnRegresarCSLTVenta.TabIndex = 56;
            this.btnRegresarCSLTVenta.Text = "Regresar";
            this.btnRegresarCSLTVenta.UseVisualStyleBackColor = true;
            // 
            // dgvCSLTVenta
            // 
            this.dgvCSLTVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSLTVenta.Location = new System.Drawing.Point(350, 81);
            this.dgvCSLTVenta.Name = "dgvCSLTVenta";
            this.dgvCSLTVenta.RowHeadersWidth = 51;
            this.dgvCSLTVenta.Size = new System.Drawing.Size(691, 262);
            this.dgvCSLTVenta.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 75);
            this.panel1.TabIndex = 54;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(939, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(103, 29);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Usuario";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.Location = new System.Drawing.Point(408, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(342, 31);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "CONSULTA DE VENTAS";
            // 
            // CSLT_Venta_Productos
            // 
            this.ClientSize = new System.Drawing.Size(1041, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarCSLTVenta);
            this.Controls.Add(this.dgvCSLTVenta);
            this.Controls.Add(this.panel1);
            this.Name = "CSLT_Venta_Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSLTVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
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
            cmbProductoCSLTVenta.DataSource = logProducto.Instancia.CargarNombreCSLT();
            cmbProductoCSLTVenta.DisplayMember = "NomProducto";
            cmbProductoCSLTVenta.ValueMember = "ProductosID";

            cmbMetodoPagoCSLTVenta.DataSource = logMetodoPago.Instancia.CargarTipoMetodoPago();
            cmbMetodoPagoCSLTVenta.DisplayMember = "NomTipometodoP";
            cmbMetodoPagoCSLTVenta.ValueMember = "TipometodopagoID";

            cmbMarcaCSLTVenta.DataSource = logMarca.Instancia.CargarMarcaCSLT();
            cmbMarcaCSLTVenta.DisplayMember = "NomMarca";
            cmbMarcaCSLTVenta.ValueMember = "MarcaID";

            cmbCategoriaCSLTVenta.DataSource = logProducto.Instancia.CargarCategoria();
            cmbCategoriaCSLTVenta.DisplayMember = "NomCategoria";
            cmbCategoriaCSLTVenta.ValueMember = "CategoriaID";
        }

        private void btnBuscarCSLTVenta_Click(object sender, EventArgs e)
        {
            bool? estVenta = ckbEstadoCSLTVenta.Checked ? (bool?)true : (bool?)null;
            DateTime? FechaVenProd = dtpFechaCSLTVenta.Value.Date;
            int? DetalleventaproductoID = string.IsNullOrEmpty(txtIDDetalleCSLTVenta.Text) ? (int?)null : int.Parse(txtIDDetalleCSLTVenta.Text);
            int? VentaproductoID = string.IsNullOrEmpty(txtIDVentaCSLTVenta.Text) ? (int?)null : int.Parse(txtIDVentaCSLTVenta.Text);
            string NomProducto = string.IsNullOrEmpty(cmbProductoCSLTVenta.Text) ? null : cmbProductoCSLTVenta.Text;
            string NomCategoria = string.IsNullOrEmpty(cmbCategoriaCSLTVenta.Text) ? null : cmbCategoriaCSLTVenta.Text;
            string NomMarca = string.IsNullOrEmpty(cmbMarcaCSLTVenta.Text) ? null : cmbMarcaCSLTVenta.Text;
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
            cmbProductoCSLTVenta.SelectedIndex = -1;
            cmbCategoriaCSLTVenta.SelectedIndex = -1;
            cmbMarcaCSLTVenta.SelectedIndex = -1;
            cmbMetodoPagoCSLTVenta.SelectedIndex = -1;
        }
        private void ListarVentaProducto()
        {
            dgvCSLTVenta.DataSource = logVentaProdCon.Instancia.ListarVentaProducto();
        }
    }
}
