namespace Turky_sGym_Programa
{
    partial class CRUD_Membresía
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
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPlanes = new System.Windows.Forms.GroupBox();
            this.dtpDuracion = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTipoPromocion = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.gbPlanes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(944, 229);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnhabilitar.TabIndex = 36;
            this.btnhabilitar.Text = "HABILITAR";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(944, 284);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 51);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvPlan
            // 
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan,
            this.precio,
            this.duracion,
            this.servicio,
            this.estado});
            this.dgvPlan.Location = new System.Drawing.Point(30, 114);
            this.dgvPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(874, 228);
            this.dgvPlan.TabIndex = 30;
            this.dgvPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellDoubleClick);
            this.dgvPlan.DoubleClick += new System.EventHandler(this.dgvPlan_DoubleClick);
            // 
            // plan
            // 
            this.plan.HeaderText = "PLAN";
            this.plan.Name = "plan";
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            // 
            // duracion
            // 
            this.duracion.HeaderText = "DURACION";
            this.duracion.Name = "duracion";
            // 
            // servicio
            // 
            this.servicio.HeaderText = "SERVICIO";
            this.servicio.Name = "servicio";
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            // 
            // gbPlanes
            // 
            this.gbPlanes.Controls.Add(this.dtpDuracion);
            this.gbPlanes.Controls.Add(this.cbEstado);
            this.gbPlanes.Controls.Add(this.lbID);
            this.gbPlanes.Controls.Add(this.label4);
            this.gbPlanes.Controls.Add(this.cmbServicio);
            this.gbPlanes.Controls.Add(this.label3);
            this.gbPlanes.Controls.Add(this.txtPlan);
            this.gbPlanes.Controls.Add(this.label1);
            this.gbPlanes.Controls.Add(this.btnCancelar);
            this.gbPlanes.Controls.Add(this.btnGuardar);
            this.gbPlanes.Controls.Add(this.lblNombre);
            this.gbPlanes.Controls.Add(this.txtPrecio);
            this.gbPlanes.Controls.Add(this.lblTipoPromocion);
            this.gbPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlanes.Location = new System.Drawing.Point(30, 379);
            this.gbPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Name = "gbPlanes";
            this.gbPlanes.Padding = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Size = new System.Drawing.Size(1024, 262);
            this.gbPlanes.TabIndex = 33;
            this.gbPlanes.TabStop = false;
            this.gbPlanes.Text = "Planes";
            // 
            // dtpDuracion
            // 
            this.dtpDuracion.Location = new System.Drawing.Point(140, 171);
            this.dtpDuracion.Name = "dtpDuracion";
            this.dtpDuracion.Size = new System.Drawing.Size(239, 22);
            this.dtpDuracion.TabIndex = 25;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(310, 51);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(69, 20);
            this.cbEstado.TabIndex = 24;
            this.cbEstado.Text = "Estado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(140, 57);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id:";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(706, 84);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(168, 24);
            this.cmbServicio.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servicios a agregar:";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(140, 89);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(239, 22);
            this.txtPlan.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duración:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(575, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(437, 158);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(77, 129);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 126);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(239, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblTipoPromocion
            // 
            this.lblTipoPromocion.AutoSize = true;
            this.lblTipoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPromocion.Location = new System.Drawing.Point(89, 95);
            this.lblTipoPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPromocion.Name = "lblTipoPromocion";
            this.lblTipoPromocion.Size = new System.Drawing.Size(37, 16);
            this.lblTipoPromocion.TabIndex = 1;
            this.lblTipoPromocion.Text = "Plan:";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(944, 174);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnInhabilitar.TabIndex = 32;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(944, 119);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 51);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 68);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(457, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "MEMBRESÍA";
            // 
            // CRUD_Membresía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 726);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.gbPlanes);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Membresía";
            this.Text = "CRUD_Membresía";
            this.Load += new System.EventHandler(this.CRUD_Membresía_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.gbPlanes.ResumeLayout(false);
            this.gbPlanes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox gbPlanes;
        private System.Windows.Forms.DateTimePicker dtpDuracion;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTipoPromocion;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}