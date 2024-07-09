namespace Turky_sGym_Programa
{
    partial class CORE_VENTA_PRODUCTOS
    {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConsultarVentasProducto = new System.Windows.Forms.Button();
            this.btnAnularVentaProducto = new System.Windows.Forms.Button();
            this.btnRegistroVProducto = new System.Windows.Forms.Button();
            this.lblFechaRegistroP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVentaServicios = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lbProm = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbPromocion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioUni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVentaProductos = new System.Windows.Forms.DataGridView();
            this.Productoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promocion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoMetodo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarVentasProducto
            // 
            this.btnConsultarVentasProducto.Location = new System.Drawing.Point(820, 571);
            this.btnConsultarVentasProducto.Name = "btnConsultarVentasProducto";
            this.btnConsultarVentasProducto.Size = new System.Drawing.Size(125, 41);
            this.btnConsultarVentasProducto.TabIndex = 56;
            this.btnConsultarVentasProducto.Text = "CONSULTAR VENTAS";
            this.btnConsultarVentasProducto.UseVisualStyleBackColor = true;
            // 
            // btnAnularVentaProducto
            // 
            this.btnAnularVentaProducto.Location = new System.Drawing.Point(820, 477);
            this.btnAnularVentaProducto.Name = "btnAnularVentaProducto";
            this.btnAnularVentaProducto.Size = new System.Drawing.Size(125, 40);
            this.btnAnularVentaProducto.TabIndex = 52;
            this.btnAnularVentaProducto.Text = "ANULAR VENTA";
            this.btnAnularVentaProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegistroVProducto
            // 
            this.btnRegistroVProducto.Location = new System.Drawing.Point(820, 367);
            this.btnRegistroVProducto.Name = "btnRegistroVProducto";
            this.btnRegistroVProducto.Size = new System.Drawing.Size(125, 41);
            this.btnRegistroVProducto.TabIndex = 51;
            this.btnRegistroVProducto.Text = "GUARDAR";
            this.btnRegistroVProducto.UseVisualStyleBackColor = true;
            this.btnRegistroVProducto.Click += new System.EventHandler(this.btnRegistroVProducto_Click);
            // 
            // lblFechaRegistroP
            // 
            this.lblFechaRegistroP.AutoSize = true;
            this.lblFechaRegistroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistroP.Location = new System.Drawing.Point(-113, 403);
            this.lblFechaRegistroP.Name = "lblFechaRegistroP";
            this.lblFechaRegistroP.Size = new System.Drawing.Size(105, 16);
            this.lblFechaRegistroP.TabIndex = 49;
            this.lblFechaRegistroP.Text = "Fecha de Venta:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblVentaServicios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 79);
            this.panel1.TabIndex = 63;
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVentaServicios.Location = new System.Drawing.Point(393, 18);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(302, 31);
            this.lblVentaServicios.TabIndex = 44;
            this.lblVentaServicios.Text = "VENTA PRODUCTOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNombre);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.lbID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.lbProm);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cmbPromocion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescProducto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPrecioUni);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMontoPagar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 231);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(116, 95);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(121, 21);
            this.cmbNombre.TabIndex = 72;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(116, 60);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 71;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(121, 33);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 13);
            this.lbID.TabIndex = 70;
            this.lbID.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 69;
            this.label13.Text = "Categoria:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(670, 190);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 30);
            this.btnQuitar.TabIndex = 68;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lbProm
            // 
            this.lbProm.AutoSize = true;
            this.lbProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProm.Location = new System.Drawing.Point(7, 202);
            this.lbProm.Name = "lbProm";
            this.lbProm.Size = new System.Drawing.Size(96, 18);
            this.lbProm.TabIndex = 25;
            this.lbProm.Text = "Promocion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(560, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbPromocion
            // 
            this.cmbPromocion.FormattingEnabled = true;
            this.cmbPromocion.Location = new System.Drawing.Point(116, 203);
            this.cmbPromocion.Name = "cmbPromocion";
            this.cmbPromocion.Size = new System.Drawing.Size(121, 21);
            this.cmbPromocion.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre:";
            // 
            // txtDescProducto
            // 
            this.txtDescProducto.Location = new System.Drawing.Point(116, 132);
            this.txtDescProducto.Name = "txtDescProducto";
            this.txtDescProducto.ReadOnly = true;
            this.txtDescProducto.Size = new System.Drawing.Size(391, 20);
            this.txtDescProducto.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descripcion:";
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(623, 68);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.ReadOnly = true;
            this.txtPrecioUni.Size = new System.Drawing.Size(101, 20);
            this.txtPrecioUni.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio Unidad:";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(420, 200);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(87, 20);
            this.txtMontoPagar.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(623, 29);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(101, 20);
            this.txtStock.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Stock:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 168);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(101, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(989, 265);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cmbFormaPago.TabIndex = 72;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(989, 214);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodoPago.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Forma de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Metodo de Pago:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Fecha:";
            // 
            // dtgVentaProductos
            // 
            this.dtgVentaProductos.AllowUserToAddRows = false;
            this.dtgVentaProductos.AllowUserToDeleteRows = false;
            this.dtgVentaProductos.AllowUserToResizeColumns = false;
            this.dtgVentaProductos.AllowUserToResizeRows = false;
            this.dtgVentaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productoid,
            this.NombreProd,
            this.DescProducto,
            this.Cantidad,
            this.PrecioUni,
            this.Promocion,
            this.precioTotal,
            this.precioDescuento});
            this.dtgVentaProductos.Location = new System.Drawing.Point(18, 367);
            this.dtgVentaProductos.Name = "dtgVentaProductos";
            this.dtgVentaProductos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVentaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentaProductos.Size = new System.Drawing.Size(759, 245);
            this.dtgVentaProductos.TabIndex = 73;
            // 
            // Productoid
            // 
            this.Productoid.HeaderText = "PRODUCTO";
            this.Productoid.Name = "Productoid";
            this.Productoid.ReadOnly = true;
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "NOMBRE";
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.ReadOnly = true;
            this.NombreProd.Width = 150;
            // 
            // DescProducto
            // 
            this.DescProducto.HeaderText = "DESCRIPCION";
            this.DescProducto.Name = "DescProducto";
            this.DescProducto.ReadOnly = true;
            this.DescProducto.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUni
            // 
            this.PrecioUni.HeaderText = "PRECIO";
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.ReadOnly = true;
            this.PrecioUni.Width = 110;
            // 
            // Promocion
            // 
            this.Promocion.HeaderText = "PROMOCION";
            this.Promocion.Name = "Promocion";
            this.Promocion.ReadOnly = true;
            this.Promocion.Width = 130;
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "SUBTOTAL";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            // 
            // precioDescuento
            // 
            this.precioDescuento.HeaderText = "PRECIO DESCUENTO";
            this.precioDescuento.Name = "precioDescuento";
            this.precioDescuento.ReadOnly = true;
            // 
            // cmbTipoMetodo
            // 
            this.cmbTipoMetodo.FormattingEnabled = true;
            this.cmbTipoMetodo.Location = new System.Drawing.Point(989, 156);
            this.cmbTipoMetodo.Name = "cmbTipoMetodo";
            this.cmbTipoMetodo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMetodo.TabIndex = 75;
            this.cmbTipoMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMetodo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(783, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 18);
            this.label12.TabIndex = 74;
            this.label12.Text = "Tipo Metodo de Pago:";
            // 
            // CORE_VENTA_PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 624);
            this.Controls.Add(this.cmbTipoMetodo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgVentaProductos);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarVentasProducto);
            this.Controls.Add(this.btnAnularVentaProducto);
            this.Controls.Add(this.btnRegistroVProducto);
            this.Controls.Add(this.lblFechaRegistroP);
            this.Controls.Add(this.panel1);
            this.Name = "CORE_VENTA_PRODUCTOS";
            this.Text = "CORE_VENTA_PRODUCTOS";
            this.Load += new System.EventHandler(this.CORE_VENTA_PRODUCTOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarVentasProducto;
        private System.Windows.Forms.Button btnAnularVentaProducto;
        private System.Windows.Forms.Button btnRegistroVProducto;
        private System.Windows.Forms.Label lblFechaRegistroP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioUni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbProm;
        private System.Windows.Forms.ComboBox cmbPromocion;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.DataGridView dtgVentaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDescuento;
        private System.Windows.Forms.ComboBox cmbTipoMetodo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}