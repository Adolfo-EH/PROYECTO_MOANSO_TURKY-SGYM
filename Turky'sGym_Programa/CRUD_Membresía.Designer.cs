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
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.gbPlanes = new System.Windows.Forms.GroupBox();
            this.listServicios = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDuracionMem = new System.Windows.Forms.TextBox();
            this.lbIDMembresia = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMembresia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.holi = new System.Windows.Forms.Label();
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
            this.btnhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnhabilitar.Location = new System.Drawing.Point(1059, 249);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnhabilitar.TabIndex = 36;
            this.btnhabilitar.Text = "HABILITAR";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // dgvPlan
            // 
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(11, 93);
            this.dgvPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(1024, 402);
            this.dgvPlan.TabIndex = 30;
            this.dgvPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellDoubleClick);
            // 
            // gbPlanes
            // 
            this.gbPlanes.Controls.Add(this.listServicios);
            this.gbPlanes.Controls.Add(this.btnAgregar);
            this.gbPlanes.Controls.Add(this.txtDuracionMem);
            this.gbPlanes.Controls.Add(this.lbIDMembresia);
            this.gbPlanes.Controls.Add(this.cbEstado);
            this.gbPlanes.Controls.Add(this.label4);
            this.gbPlanes.Controls.Add(this.cmbServicio);
            this.gbPlanes.Controls.Add(this.label3);
            this.gbPlanes.Controls.Add(this.txtMembresia);
            this.gbPlanes.Controls.Add(this.label1);
            this.gbPlanes.Controls.Add(this.btnCancelar);
            this.gbPlanes.Controls.Add(this.btnGuardar);
            this.gbPlanes.Controls.Add(this.lblNombre);
            this.gbPlanes.Controls.Add(this.txtPrecio);
            this.gbPlanes.Controls.Add(this.holi);
            this.gbPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlanes.Location = new System.Drawing.Point(11, 499);
            this.gbPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Name = "gbPlanes";
            this.gbPlanes.Padding = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Size = new System.Drawing.Size(1162, 411);
            this.gbPlanes.TabIndex = 33;
            this.gbPlanes.TabStop = false;
            this.gbPlanes.Text = "Planes";
            // 
            // listServicios
            // 
            this.listServicios.FormattingEnabled = true;
            this.listServicios.ItemHeight = 16;
            this.listServicios.Location = new System.Drawing.Point(754, 79);
            this.listServicios.Name = "listServicios";
            this.listServicios.Size = new System.Drawing.Size(229, 308);
            this.listServicios.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAgregar.Location = new System.Drawing.Point(1048, 26);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 45);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDuracionMem
            // 
            this.txtDuracionMem.Location = new System.Drawing.Point(140, 180);
            this.txtDuracionMem.Name = "txtDuracionMem";
            this.txtDuracionMem.Size = new System.Drawing.Size(239, 22);
            this.txtDuracionMem.TabIndex = 27;
            // 
            // lbIDMembresia
            // 
            this.lbIDMembresia.AutoSize = true;
            this.lbIDMembresia.Location = new System.Drawing.Point(137, 94);
            this.lbIDMembresia.Name = "lbIDMembresia";
            this.lbIDMembresia.Size = new System.Drawing.Size(21, 16);
            this.lbIDMembresia.TabIndex = 26;
            this.lbIDMembresia.Text = "00";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(465, 93);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(69, 20);
            this.cbEstado.TabIndex = 24;
            this.cbEstado.Text = "Estado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id:";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(754, 37);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(270, 24);
            this.cmbServicio.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servicios a agregar:";
            // 
            // txtMembresia
            // 
            this.txtMembresia.Location = new System.Drawing.Point(140, 131);
            this.txtMembresia.Name = "txtMembresia";
            this.txtMembresia.Size = new System.Drawing.Size(396, 22);
            this.txtMembresia.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duración:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(1000, 307);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGuardar.Location = new System.Drawing.Point(1000, 231);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 45);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "INSERTAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(402, 186);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(465, 186);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // holi
            // 
            this.holi.AutoSize = true;
            this.holi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holi.Location = new System.Drawing.Point(48, 134);
            this.holi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.holi.Name = "holi";
            this.holi.Size = new System.Drawing.Size(78, 16);
            this.holi.TabIndex = 1;
            this.holi.Text = "Membresia:";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnInhabilitar.Location = new System.Drawing.Point(1059, 341);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitar.TabIndex = 32;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(1059, 169);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 50);
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
            this.panel1.Size = new System.Drawing.Size(1184, 79);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(500, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "MEMBRESÍA";
            // 
            // CRUD_Membresía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.btnhabilitar);
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
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.GroupBox gbPlanes;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMembresia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label holi;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lbIDMembresia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuracionMem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listServicios;
    }
}