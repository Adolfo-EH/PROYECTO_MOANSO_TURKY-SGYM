namespace Turky_sGym_Programa
{
    partial class CRUD_Promocion
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.gbPromocion = new System.Windows.Forms.GroupBox();
            this.cbxPromocion = new System.Windows.Forms.CheckBox();
            this.dtpDuracion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.cmbTipoProm = new System.Windows.Forms.ComboBox();
            this.lblTipoPromocion = new System.Windows.Forms.Label();
            this.lblIdPromocion = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.gbPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 74);
            this.panel1.TabIndex = 23;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Titulo.Location = new System.Drawing.Point(348, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(232, 31);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "PROMOCIONES";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(692, 555);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 51);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Location = new System.Drawing.Point(25, 98);
            this.dgvPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowHeadersWidth = 51;
            this.dgvPromocion.RowTemplate.Height = 24;
            this.dgvPromocion.Size = new System.Drawing.Size(628, 228);
            this.dgvPromocion.TabIndex = 17;
            this.dgvPromocion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromocion_CellDoubleClick);
            // 
            // gbPromocion
            // 
            this.gbPromocion.Controls.Add(this.cbxPromocion);
            this.gbPromocion.Controls.Add(this.dtpDuracion);
            this.gbPromocion.Controls.Add(this.label1);
            this.gbPromocion.Controls.Add(this.btnCancelar);
            this.gbPromocion.Controls.Add(this.btnGuardar);
            this.gbPromocion.Controls.Add(this.txtDescuento);
            this.gbPromocion.Controls.Add(this.lblNombre);
            this.gbPromocion.Controls.Add(this.txtNombre);
            this.gbPromocion.Controls.Add(this.lblDescuento);
            this.gbPromocion.Controls.Add(this.lbID);
            this.gbPromocion.Controls.Add(this.cmbTipoProm);
            this.gbPromocion.Controls.Add(this.lblTipoPromocion);
            this.gbPromocion.Controls.Add(this.lblIdPromocion);
            this.gbPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromocion.Location = new System.Drawing.Point(120, 394);
            this.gbPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.gbPromocion.Name = "gbPromocion";
            this.gbPromocion.Padding = new System.Windows.Forms.Padding(2);
            this.gbPromocion.Size = new System.Drawing.Size(509, 212);
            this.gbPromocion.TabIndex = 21;
            this.gbPromocion.TabStop = false;
            this.gbPromocion.Text = "Promociones(Productos/Servicios)";
            // 
            // cbxPromocion
            // 
            this.cbxPromocion.AutoSize = true;
            this.cbxPromocion.Location = new System.Drawing.Point(268, 29);
            this.cbxPromocion.Name = "cbxPromocion";
            this.cbxPromocion.Size = new System.Drawing.Size(73, 20);
            this.cbxPromocion.TabIndex = 31;
            this.cbxPromocion.Text = "Estado ";
            this.cbxPromocion.UseVisualStyleBackColor = true;
            // 
            // dtpDuracion
            // 
            this.dtpDuracion.Location = new System.Drawing.Point(140, 169);
            this.dtpDuracion.Name = "dtpDuracion";
            this.dtpDuracion.Size = new System.Drawing.Size(200, 22);
            this.dtpDuracion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duración";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 111);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(407, 54);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(140, 134);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(200, 22);
            this.txtDescuento.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 102);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 98);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(54, 138);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(73, 16);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(137, 29);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 16);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "00";
            // 
            // cmbTipoProm
            // 
            this.cmbTipoProm.FormattingEnabled = true;
            this.cmbTipoProm.Items.AddRange(new object[] {
            "Servicios",
            "Productos"});
            this.cmbTipoProm.Location = new System.Drawing.Point(140, 59);
            this.cmbTipoProm.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoProm.Name = "cmbTipoProm";
            this.cmbTipoProm.Size = new System.Drawing.Size(200, 24);
            this.cmbTipoProm.TabIndex = 2;
            // 
            // lblTipoPromocion
            // 
            this.lblTipoPromocion.AutoSize = true;
            this.lblTipoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPromocion.Location = new System.Drawing.Point(4, 62);
            this.lblTipoPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPromocion.Name = "lblTipoPromocion";
            this.lblTipoPromocion.Size = new System.Drawing.Size(123, 16);
            this.lblTipoPromocion.TabIndex = 1;
            this.lblTipoPromocion.Text = "Tipo de Promoción";
            // 
            // lblIdPromocion
            // 
            this.lblIdPromocion.AutoSize = true;
            this.lblIdPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPromocion.Location = new System.Drawing.Point(43, 29);
            this.lblIdPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPromocion.Name = "lblIdPromocion";
            this.lblIdPromocion.Size = new System.Drawing.Size(84, 16);
            this.lblIdPromocion.TabIndex = 0;
            this.lblIdPromocion.Text = "IdPromoción";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(692, 284);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnInhabilitar.TabIndex = 20;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(692, 195);
            this.btnHabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnHabilitar.TabIndex = 19;
            this.btnHabilitar.Text = "HABILITAR";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(692, 98);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 51);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // CRUD_Promocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvPromocion);
            this.Controls.Add(this.gbPromocion);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "CRUD_Promocion";
            this.Text = "CRUD_Promocion";
            this.Load += new System.EventHandler(this.CRUD_Promocion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.gbPromocion.ResumeLayout(false);
            this.gbPromocion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvPromocion;
        private System.Windows.Forms.GroupBox gbPromocion;
        private System.Windows.Forms.CheckBox cbxPromocion;
        private System.Windows.Forms.DateTimePicker dtpDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cmbTipoProm;
        private System.Windows.Forms.Label lblTipoPromocion;
        private System.Windows.Forms.Label lblIdPromocion;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnNuevo;
    }
}