namespace Turky_sGym_Programa
{
    partial class CSLT_Venta_Productos
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProductoCSLTVenta;
        private System.Windows.Forms.ComboBox cmbCategoriaCSLTVenta;
        private System.Windows.Forms.ComboBox cmbMarcaCSLTVenta;
        private System.Windows.Forms.ComboBox cmbMetodoPagoCSLTVenta;
        private System.Windows.Forms.CheckBox ckbEstadoCSLTVenta;
        private System.Windows.Forms.Label lblCategoriaCSLTVenta;
        private System.Windows.Forms.Button btnBuscarCSLTVenta;
        private System.Windows.Forms.Label lblFechaCSLTVenta;
        private System.Windows.Forms.Label lblMetodoPagoCSLTVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaCSLTVenta;
        private System.Windows.Forms.TextBox txtIDDetalleCSLTVenta;
        private System.Windows.Forms.Label lblDetalleCSLTVenta;
        private System.Windows.Forms.Label lblEstadoCSLTVenta;
        private System.Windows.Forms.TextBox txtIDVentaCSLTVenta;
        private System.Windows.Forms.Label lblVentaCSLTVenta;
        private System.Windows.Forms.Label lblProductoCSLTVenta;
        private System.Windows.Forms.Label lblMarcaCSLTVenta;
        private System.Windows.Forms.Button btnRegresarCSLTVenta;
        private System.Windows.Forms.DataGridView dgvCSLTVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label Titulo;
        /*
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;

/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
protected override void Dispose(bool disposing)
{
if (disposing && (components != null))
{
components.Dispose();
}
base.Dispose(disposing);
}

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
this.panel1 = new System.Windows.Forms.Panel();
this.lblUsuario = new System.Windows.Forms.Label();
this.Titulo = new System.Windows.Forms.Label();
this.groupBox1 = new System.Windows.Forms.GroupBox();
this.cmbMetodoPagoCSLTVenta = new System.Windows.Forms.ComboBox();
this.ckbEstadoCSLTVenta = new System.Windows.Forms.CheckBox();
this.txtCategoriaCSLTVenta = new System.Windows.Forms.TextBox();
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
this.txtMarcaCSLTVenta = new System.Windows.Forms.TextBox();
this.txtProductoCSLTVenta = new System.Windows.Forms.TextBox();
this.lblProductoCSLTVenta = new System.Windows.Forms.Label();
this.lblMarcaCSLTVenta = new System.Windows.Forms.Label();
this.btnRegresarCSLTVenta = new System.Windows.Forms.Button();
this.dgvCSLTVenta = new System.Windows.Forms.DataGridView();
this.panel1.SuspendLayout();
this.groupBox1.SuspendLayout();
((System.ComponentModel.ISupportInitialize)(this.dgvCSLTVenta)).BeginInit();
this.SuspendLayout();
// 
// panel1
// 
this.panel1.BackColor = System.Drawing.Color.DarkCyan;
this.panel1.Controls.Add(this.lblUsuario);
this.panel1.Controls.Add(this.Titulo);
this.panel1.Location = new System.Drawing.Point(-3, 0);
this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
this.panel1.Name = "panel1";
this.panel1.Size = new System.Drawing.Size(1387, 92);
this.panel1.TabIndex = 21;
// 
// lblUsuario
// 
this.lblUsuario.AutoSize = true;
this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
this.lblUsuario.Location = new System.Drawing.Point(1252, 27);
this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
this.Titulo.Location = new System.Drawing.Point(544, 27);
this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.Titulo.Name = "Titulo";
this.Titulo.Size = new System.Drawing.Size(342, 31);
this.Titulo.TabIndex = 1;
this.Titulo.Text = "CONSULTA DE VENTAS";
// 
// groupBox1
// 
this.groupBox1.Controls.Add(this.cmbMetodoPagoCSLTVenta);
this.groupBox1.Controls.Add(this.ckbEstadoCSLTVenta);
this.groupBox1.Controls.Add(this.txtCategoriaCSLTVenta);
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
this.groupBox1.Controls.Add(this.txtMarcaCSLTVenta);
this.groupBox1.Controls.Add(this.txtProductoCSLTVenta);
this.groupBox1.Controls.Add(this.lblProductoCSLTVenta);
this.groupBox1.Controls.Add(this.lblMarcaCSLTVenta);
this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.groupBox1.Location = new System.Drawing.Point(5, 100);
this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.groupBox1.Name = "groupBox1";
this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.groupBox1.Size = new System.Drawing.Size(451, 324);
this.groupBox1.TabIndex = 53;
this.groupBox1.TabStop = false;
this.groupBox1.Text = "Llena filtros para la búsqueda:";
// 
// cmbMetodoPagoCSLTVenta
// 
this.cmbMetodoPagoCSLTVenta.FormattingEnabled = true;
this.cmbMetodoPagoCSLTVenta.Location = new System.Drawing.Point(235, 228);
this.cmbMetodoPagoCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.cmbMetodoPagoCSLTVenta.Name = "cmbMetodoPagoCSLTVenta";
this.cmbMetodoPagoCSLTVenta.Size = new System.Drawing.Size(193, 25);
this.cmbMetodoPagoCSLTVenta.TabIndex = 23;
// 
// ckbEstadoCSLTVenta
// 
this.ckbEstadoCSLTVenta.AutoSize = true;
this.ckbEstadoCSLTVenta.Location = new System.Drawing.Point(23, 59);
this.ckbEstadoCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.ckbEstadoCSLTVenta.Name = "ckbEstadoCSLTVenta";
this.ckbEstadoCSLTVenta.Size = new System.Drawing.Size(73, 22);
this.ckbEstadoCSLTVenta.TabIndex = 37;
this.ckbEstadoCSLTVenta.Text = "Activo";
this.ckbEstadoCSLTVenta.UseVisualStyleBackColor = true;
// 
// txtCategoriaCSLTVenta
// 
this.txtCategoriaCSLTVenta.Location = new System.Drawing.Point(235, 121);
this.txtCategoriaCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtCategoriaCSLTVenta.Name = "txtCategoriaCSLTVenta";
this.txtCategoriaCSLTVenta.Size = new System.Drawing.Size(193, 24);
this.txtCategoriaCSLTVenta.TabIndex = 36;
// 
// lblCategoriaCSLTVenta
// 
this.lblCategoriaCSLTVenta.AutoSize = true;
this.lblCategoriaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblCategoriaCSLTVenta.Location = new System.Drawing.Point(225, 97);
this.lblCategoriaCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblCategoriaCSLTVenta.Name = "lblCategoriaCSLTVenta";
this.lblCategoriaCSLTVenta.Size = new System.Drawing.Size(66, 16);
this.lblCategoriaCSLTVenta.TabIndex = 35;
this.lblCategoriaCSLTVenta.Text = "Categoria";
// 
// btnBuscarCSLTVenta
// 
this.btnBuscarCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnBuscarCSLTVenta.Location = new System.Drawing.Point(147, 276);
this.btnBuscarCSLTVenta.Margin = new System.Windows.Forms.Padding(4);
this.btnBuscarCSLTVenta.Name = "btnBuscarCSLTVenta";
this.btnBuscarCSLTVenta.Size = new System.Drawing.Size(125, 41);
this.btnBuscarCSLTVenta.TabIndex = 18;
this.btnBuscarCSLTVenta.Text = "Buscar";
this.btnBuscarCSLTVenta.UseVisualStyleBackColor = true;
this.btnBuscarCSLTVenta.Click += new System.EventHandler(this.btnBuscarCSLTVenta_Click);
// 
// lblFechaCSLTVenta
// 
this.lblFechaCSLTVenta.AutoSize = true;
this.lblFechaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblFechaCSLTVenta.Location = new System.Drawing.Point(143, 36);
this.lblFechaCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblFechaCSLTVenta.Name = "lblFechaCSLTVenta";
this.lblFechaCSLTVenta.Size = new System.Drawing.Size(105, 16);
this.lblFechaCSLTVenta.TabIndex = 17;
this.lblFechaCSLTVenta.Text = "Fecha de Venta:";
// 
// lblMetodoPagoCSLTVenta
// 
this.lblMetodoPagoCSLTVenta.AutoSize = true;
this.lblMetodoPagoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblMetodoPagoCSLTVenta.Location = new System.Drawing.Point(225, 206);
this.lblMetodoPagoCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblMetodoPagoCSLTVenta.Name = "lblMetodoPagoCSLTVenta";
this.lblMetodoPagoCSLTVenta.Size = new System.Drawing.Size(89, 16);
this.lblMetodoPagoCSLTVenta.TabIndex = 31;
this.lblMetodoPagoCSLTVenta.Text = "Método Pago";
// 
// dtpFechaCSLTVenta
// 
this.dtpFechaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.dtpFechaCSLTVenta.Location = new System.Drawing.Point(147, 57);
this.dtpFechaCSLTVenta.Margin = new System.Windows.Forms.Padding(4);
this.dtpFechaCSLTVenta.Name = "dtpFechaCSLTVenta";
this.dtpFechaCSLTVenta.Size = new System.Drawing.Size(281, 22);
this.dtpFechaCSLTVenta.TabIndex = 16;
// 
// txtIDDetalleCSLTVenta
// 
this.txtIDDetalleCSLTVenta.Location = new System.Drawing.Point(11, 121);
this.txtIDDetalleCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtIDDetalleCSLTVenta.Name = "txtIDDetalleCSLTVenta";
this.txtIDDetalleCSLTVenta.Size = new System.Drawing.Size(193, 24);
this.txtIDDetalleCSLTVenta.TabIndex = 30;
// 
// lblDetalleCSLTVenta
// 
this.lblDetalleCSLTVenta.AutoSize = true;
this.lblDetalleCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblDetalleCSLTVenta.Location = new System.Drawing.Point(7, 97);
this.lblDetalleCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblDetalleCSLTVenta.Name = "lblDetalleCSLTVenta";
this.lblDetalleCSLTVenta.Size = new System.Drawing.Size(104, 16);
this.lblDetalleCSLTVenta.TabIndex = 29;
this.lblDetalleCSLTVenta.Text = "ID Detalle Venta";
// 
// lblEstadoCSLTVenta
// 
this.lblEstadoCSLTVenta.AutoSize = true;
this.lblEstadoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblEstadoCSLTVenta.Location = new System.Drawing.Point(7, 36);
this.lblEstadoCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblEstadoCSLTVenta.Name = "lblEstadoCSLTVenta";
this.lblEstadoCSLTVenta.Size = new System.Drawing.Size(50, 16);
this.lblEstadoCSLTVenta.TabIndex = 28;
this.lblEstadoCSLTVenta.Text = "Estado";
// 
// txtIDVentaCSLTVenta
// 
this.txtIDVentaCSLTVenta.Location = new System.Drawing.Point(11, 174);
this.txtIDVentaCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtIDVentaCSLTVenta.Name = "txtIDVentaCSLTVenta";
this.txtIDVentaCSLTVenta.Size = new System.Drawing.Size(193, 24);
this.txtIDVentaCSLTVenta.TabIndex = 26;
// 
// lblVentaCSLTVenta
// 
this.lblVentaCSLTVenta.AutoSize = true;
this.lblVentaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblVentaCSLTVenta.Location = new System.Drawing.Point(7, 151);
this.lblVentaCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblVentaCSLTVenta.Name = "lblVentaCSLTVenta";
this.lblVentaCSLTVenta.Size = new System.Drawing.Size(134, 16);
this.lblVentaCSLTVenta.TabIndex = 25;
this.lblVentaCSLTVenta.Text = "ID Venta de Producto";
// 
// txtMarcaCSLTVenta
// 
this.txtMarcaCSLTVenta.Location = new System.Drawing.Point(235, 174);
this.txtMarcaCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtMarcaCSLTVenta.Name = "txtMarcaCSLTVenta";
this.txtMarcaCSLTVenta.Size = new System.Drawing.Size(193, 24);
this.txtMarcaCSLTVenta.TabIndex = 24;
// 
// txtProductoCSLTVenta
// 
this.txtProductoCSLTVenta.Location = new System.Drawing.Point(11, 228);
this.txtProductoCSLTVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtProductoCSLTVenta.Name = "txtProductoCSLTVenta";
this.txtProductoCSLTVenta.Size = new System.Drawing.Size(193, 24);
this.txtProductoCSLTVenta.TabIndex = 23;
// 
// lblProductoCSLTVenta
// 
this.lblProductoCSLTVenta.AutoSize = true;
this.lblProductoCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblProductoCSLTVenta.Location = new System.Drawing.Point(7, 206);
this.lblProductoCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblProductoCSLTVenta.Name = "lblProductoCSLTVenta";
this.lblProductoCSLTVenta.Size = new System.Drawing.Size(61, 16);
this.lblProductoCSLTVenta.TabIndex = 22;
this.lblProductoCSLTVenta.Text = "Producto";
// 
// lblMarcaCSLTVenta
// 
this.lblMarcaCSLTVenta.AutoSize = true;
this.lblMarcaCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblMarcaCSLTVenta.Location = new System.Drawing.Point(225, 151);
this.lblMarcaCSLTVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblMarcaCSLTVenta.Name = "lblMarcaCSLTVenta";
this.lblMarcaCSLTVenta.Size = new System.Drawing.Size(45, 16);
this.lblMarcaCSLTVenta.TabIndex = 19;
this.lblMarcaCSLTVenta.Text = "Marca";
// 
// btnRegresarCSLTVenta
// 
this.btnRegresarCSLTVenta.Cursor = System.Windows.Forms.Cursors.Default;
this.btnRegresarCSLTVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnRegresarCSLTVenta.Location = new System.Drawing.Point(5, 442);
this.btnRegresarCSLTVenta.Margin = new System.Windows.Forms.Padding(4);
this.btnRegresarCSLTVenta.Name = "btnRegresarCSLTVenta";
this.btnRegresarCSLTVenta.Size = new System.Drawing.Size(1363, 41);
this.btnRegresarCSLTVenta.TabIndex = 52;
this.btnRegresarCSLTVenta.Text = "Regresar";
this.btnRegresarCSLTVenta.UseVisualStyleBackColor = true;
this.btnRegresarCSLTVenta.Click += new System.EventHandler(this.btnRegresarCSLTVenta_Click);
// 
// dgvCSLTVenta
// 
this.dgvCSLTVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
this.dgvCSLTVenta.Location = new System.Drawing.Point(463, 100);
this.dgvCSLTVenta.Margin = new System.Windows.Forms.Padding(4);
this.dgvCSLTVenta.Name = "dgvCSLTVenta";
this.dgvCSLTVenta.RowHeadersWidth = 51;
this.dgvCSLTVenta.Size = new System.Drawing.Size(921, 322);
this.dgvCSLTVenta.TabIndex = 51;
// 
// CSLT_Venta_Productos
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(1390, 487);
this.Controls.Add(this.groupBox1);
this.Controls.Add(this.btnRegresarCSLTVenta);
this.Controls.Add(this.dgvCSLTVenta);
this.Controls.Add(this.panel1);
this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
this.Name = "CSLT_Venta_Productos";
this.Text = "CSLT_Productos";
this.Load += new System.EventHandler(this.CSLT_Venta_Productos_Load);
this.panel1.ResumeLayout(false);
this.panel1.PerformLayout();
this.groupBox1.ResumeLayout(false);
this.groupBox1.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.dgvCSLTVenta)).EndInit();
this.ResumeLayout(false);

}

#endregion
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.Label Titulo;
private System.Windows.Forms.Label lblUsuario;
private System.Windows.Forms.GroupBox groupBox1;
private System.Windows.Forms.ComboBox cmbMetodoPagoCSLTVenta;
private System.Windows.Forms.CheckBox ckbEstadoCSLTVenta;
private System.Windows.Forms.TextBox txtCategoriaCSLTVenta;
private System.Windows.Forms.Label lblCategoriaCSLTVenta;
private System.Windows.Forms.Button btnBuscarCSLTVenta;
private System.Windows.Forms.Label lblFechaCSLTVenta;
private System.Windows.Forms.Label lblMetodoPagoCSLTVenta;
private System.Windows.Forms.DateTimePicker dtpFechaCSLTVenta;
private System.Windows.Forms.TextBox txtIDDetalleCSLTVenta;
private System.Windows.Forms.Label lblDetalleCSLTVenta;
private System.Windows.Forms.Label lblEstadoCSLTVenta;
private System.Windows.Forms.TextBox txtIDVentaCSLTVenta;
private System.Windows.Forms.Label lblVentaCSLTVenta;
private System.Windows.Forms.TextBox txtMarcaCSLTVenta;
private System.Windows.Forms.TextBox txtProductoCSLTVenta;
private System.Windows.Forms.Label lblProductoCSLTVenta;
private System.Windows.Forms.Label lblMarcaCSLTVenta;
private System.Windows.Forms.Button btnRegresarCSLTVenta;
private System.Windows.Forms.DataGridView dgvCSLTVenta;
*/
    }
}