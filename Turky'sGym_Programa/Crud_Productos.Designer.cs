namespace Turky_sGym_Programa
{
    partial class CRUD_Productos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.grbDatosProducto = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbxEstadoProducto = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDpro = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvStockProducto = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 74);
            this.panel1.TabIndex = 24;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Titulo.Location = new System.Drawing.Point(338, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(198, 31);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "PRODUCTOS";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDatosProducto
            // 
            this.grbDatosProducto.Controls.Add(this.txtNombre);
            this.grbDatosProducto.Controls.Add(this.label1);
            this.grbDatosProducto.Controls.Add(this.cbMarca);
            this.grbDatosProducto.Controls.Add(this.cbxEstadoProducto);
            this.grbDatosProducto.Controls.Add(this.btnModificar);
            this.grbDatosProducto.Controls.Add(this.btnCancelar);
            this.grbDatosProducto.Controls.Add(this.btnInsertar);
            this.grbDatosProducto.Controls.Add(this.txtPrecio);
            this.grbDatosProducto.Controls.Add(this.txtCantidad);
            this.grbDatosProducto.Controls.Add(this.txtDescripcion);
            this.grbDatosProducto.Controls.Add(this.cmbCategoria);
            this.grbDatosProducto.Controls.Add(this.lbPrecio);
            this.grbDatosProducto.Controls.Add(this.lbCantidad);
            this.grbDatosProducto.Controls.Add(this.lbTipo);
            this.grbDatosProducto.Controls.Add(this.lbMarca);
            this.grbDatosProducto.Controls.Add(this.lbCategoria);
            this.grbDatosProducto.Controls.Add(this.lbID);
            this.grbDatosProducto.Controls.Add(this.lbIDpro);
            this.grbDatosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosProducto.Location = new System.Drawing.Point(85, 359);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Size = new System.Drawing.Size(535, 289);
            this.grbDatosProducto.TabIndex = 23;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Datos del Producto";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(166, 110);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(139, 24);
            this.cbMarca.TabIndex = 30;
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.AutoSize = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(233, 47);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(72, 20);
            this.cbxEstadoProducto.TabIndex = 29;
            this.cbxEstadoProducto.Text = "Estado ";
            this.cbxEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(418, 135);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 35);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(418, 65);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 35);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(166, 254);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(139, 22);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(166, 216);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 22);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(166, 179);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(139, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCategoria.Location = new System.Drawing.Point(166, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(139, 24);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(79, 257);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(49, 16);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(64, 219);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 16);
            this.lbCantidad.TabIndex = 5;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(48, 182);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(82, 16);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Descripción:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(80, 116);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(48, 16);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(56, 79);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(72, 16);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(163, 47);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "00";
            // 
            // lbIDpro
            // 
            this.lbIDpro.AutoSize = true;
            this.lbIDpro.Location = new System.Drawing.Point(48, 47);
            this.lbIDpro.Name = "lbIDpro";
            this.lbIDpro.Size = new System.Drawing.Size(80, 16);
            this.lbIDpro.TabIndex = 0;
            this.lbIDpro.Text = "ID Producto:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(752, 197);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 50);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(752, 287);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitar.TabIndex = 21;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(752, 381);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 50);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(752, 107);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 50);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvStockProducto
            // 
            this.dgvStockProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockProducto.Location = new System.Drawing.Point(85, 98);
            this.dgvStockProducto.Name = "dgvStockProducto";
            this.dgvStockProducto.ReadOnly = true;
            this.dgvStockProducto.RowHeadersWidth = 51;
            this.dgvStockProducto.Size = new System.Drawing.Size(535, 239);
            this.dgvStockProducto.TabIndex = 18;
            this.dgvStockProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockProducto_CellDoubleClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 22);
            this.txtNombre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre:";
            // 
            // CRUD_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvStockProducto);
            this.Name = "CRUD_Productos";
            this.Text = "CRUD_Productos";
            this.Load += new System.EventHandler(this.CRUD_Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDatosProducto.ResumeLayout(false);
            this.grbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox grbDatosProducto;
        private System.Windows.Forms.CheckBox cbxEstadoProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIDpro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvStockProducto;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}