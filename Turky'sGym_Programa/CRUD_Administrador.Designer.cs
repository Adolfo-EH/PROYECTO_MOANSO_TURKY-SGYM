namespace Turky_sGym_Programa
{
    partial class CRUD_Administrador
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
            this.btnEditarAd = new System.Windows.Forms.Button();
            this.btnHabilitarAd = new System.Windows.Forms.Button();
            this.btnInhabilitarAd = new System.Windows.Forms.Button();
            this.btnCrearAd = new System.Windows.Forms.Button();
            this.gbAdministrador = new System.Windows.Forms.GroupBox();
            this.btnActualizarAd = new System.Windows.Forms.Button();
            this.txtPassAd = new System.Windows.Forms.TextBox();
            this.lblPassAd = new System.Windows.Forms.Label();
            this.btnCancelarAd = new System.Windows.Forms.Button();
            this.btnAceptarAd = new System.Windows.Forms.Button();
            this.txtUsuarioAd = new System.Windows.Forms.TextBox();
            this.lblIDAdmin = new System.Windows.Forms.Label();
            this.lblUsuarioAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoAdmin = new System.Windows.Forms.CheckBox();
            this.dgvAdministrador = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVentaServicios = new System.Windows.Forms.Label();
            this.gbAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditarAd
            // 
            this.btnEditarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAd.Location = new System.Drawing.Point(536, 578);
            this.btnEditarAd.Name = "btnEditarAd";
            this.btnEditarAd.Size = new System.Drawing.Size(100, 50);
            this.btnEditarAd.TabIndex = 87;
            this.btnEditarAd.Text = "EDITAR";
            this.btnEditarAd.UseVisualStyleBackColor = true;
            this.btnEditarAd.Click += new System.EventHandler(this.btnEditarAd_Click);
            // 
            // btnHabilitarAd
            // 
            this.btnHabilitarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarAd.Location = new System.Drawing.Point(536, 396);
            this.btnHabilitarAd.Name = "btnHabilitarAd";
            this.btnHabilitarAd.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitarAd.TabIndex = 85;
            this.btnHabilitarAd.Text = "HABILITAR";
            this.btnHabilitarAd.UseVisualStyleBackColor = true;
            this.btnHabilitarAd.Click += new System.EventHandler(this.btnHabilitarAd_Click);
            // 
            // btnInhabilitarAd
            // 
            this.btnInhabilitarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarAd.Location = new System.Drawing.Point(536, 484);
            this.btnInhabilitarAd.Name = "btnInhabilitarAd";
            this.btnInhabilitarAd.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitarAd.TabIndex = 84;
            this.btnInhabilitarAd.Text = "INHABILITAR";
            this.btnInhabilitarAd.UseVisualStyleBackColor = true;
            this.btnInhabilitarAd.Click += new System.EventHandler(this.btnInhabilitarAd_Click);
            // 
            // btnCrearAd
            // 
            this.btnCrearAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAd.Location = new System.Drawing.Point(536, 305);
            this.btnCrearAd.Name = "btnCrearAd";
            this.btnCrearAd.Size = new System.Drawing.Size(100, 50);
            this.btnCrearAd.TabIndex = 83;
            this.btnCrearAd.Text = "NUEVO";
            this.btnCrearAd.UseVisualStyleBackColor = true;
            this.btnCrearAd.Click += new System.EventHandler(this.btnCrearAd_Click);
            // 
            // gbAdministrador
            // 
            this.gbAdministrador.Controls.Add(this.btnActualizarAd);
            this.gbAdministrador.Controls.Add(this.txtPassAd);
            this.gbAdministrador.Controls.Add(this.lblPassAd);
            this.gbAdministrador.Controls.Add(this.btnCancelarAd);
            this.gbAdministrador.Controls.Add(this.btnAceptarAd);
            this.gbAdministrador.Controls.Add(this.txtUsuarioAd);
            this.gbAdministrador.Controls.Add(this.lblIDAdmin);
            this.gbAdministrador.Controls.Add(this.lblUsuarioAd);
            this.gbAdministrador.Controls.Add(this.label2);
            this.gbAdministrador.Controls.Add(this.cbEstadoAdmin);
            this.gbAdministrador.Location = new System.Drawing.Point(12, 94);
            this.gbAdministrador.Name = "gbAdministrador";
            this.gbAdministrador.Size = new System.Drawing.Size(641, 193);
            this.gbAdministrador.TabIndex = 82;
            this.gbAdministrador.TabStop = false;
            this.gbAdministrador.Text = "Administrador";
            // 
            // btnActualizarAd
            // 
            this.btnActualizarAd.Location = new System.Drawing.Point(539, 73);
            this.btnActualizarAd.Name = "btnActualizarAd";
            this.btnActualizarAd.Size = new System.Drawing.Size(85, 45);
            this.btnActualizarAd.TabIndex = 78;
            this.btnActualizarAd.Text = "ACTUALIZAR";
            this.btnActualizarAd.UseVisualStyleBackColor = true;
            this.btnActualizarAd.Click += new System.EventHandler(this.btnActualizarAd_Click);
            // 
            // txtPassAd
            // 
            this.txtPassAd.Location = new System.Drawing.Point(93, 97);
            this.txtPassAd.Name = "txtPassAd";
            this.txtPassAd.Size = new System.Drawing.Size(254, 20);
            this.txtPassAd.TabIndex = 77;
            // 
            // lblPassAd
            // 
            this.lblPassAd.AutoSize = true;
            this.lblPassAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassAd.Location = new System.Drawing.Point(6, 98);
            this.lblPassAd.Name = "lblPassAd";
            this.lblPassAd.Size = new System.Drawing.Size(79, 16);
            this.lblPassAd.TabIndex = 76;
            this.lblPassAd.Text = "Contraseña:";
            // 
            // btnCancelarAd
            // 
            this.btnCancelarAd.Location = new System.Drawing.Point(539, 133);
            this.btnCancelarAd.Name = "btnCancelarAd";
            this.btnCancelarAd.Size = new System.Drawing.Size(85, 45);
            this.btnCancelarAd.TabIndex = 75;
            this.btnCancelarAd.Text = "CANCELAR";
            this.btnCancelarAd.UseVisualStyleBackColor = true;
            this.btnCancelarAd.Click += new System.EventHandler(this.btnCancelarAd_Click);
            // 
            // btnAceptarAd
            // 
            this.btnAceptarAd.Location = new System.Drawing.Point(539, 16);
            this.btnAceptarAd.Name = "btnAceptarAd";
            this.btnAceptarAd.Size = new System.Drawing.Size(85, 45);
            this.btnAceptarAd.TabIndex = 73;
            this.btnAceptarAd.Text = "INSERTAR";
            this.btnAceptarAd.UseVisualStyleBackColor = true;
            this.btnAceptarAd.Click += new System.EventHandler(this.btnAceptarAd_Click);
            // 
            // txtUsuarioAd
            // 
            this.txtUsuarioAd.Location = new System.Drawing.Point(93, 66);
            this.txtUsuarioAd.Name = "txtUsuarioAd";
            this.txtUsuarioAd.Size = new System.Drawing.Size(254, 20);
            this.txtUsuarioAd.TabIndex = 69;
            // 
            // lblIDAdmin
            // 
            this.lblIDAdmin.AutoSize = true;
            this.lblIDAdmin.Location = new System.Drawing.Point(91, 32);
            this.lblIDAdmin.Name = "lblIDAdmin";
            this.lblIDAdmin.Size = new System.Drawing.Size(19, 13);
            this.lblIDAdmin.TabIndex = 72;
            this.lblIDAdmin.Text = "00";
            // 
            // lblUsuarioAd
            // 
            this.lblUsuarioAd.AutoSize = true;
            this.lblUsuarioAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAd.Location = new System.Drawing.Point(6, 67);
            this.lblUsuarioAd.Name = "lblUsuarioAd";
            this.lblUsuarioAd.Size = new System.Drawing.Size(61, 16);
            this.lblUsuarioAd.TabIndex = 68;
            this.lblUsuarioAd.Text = "Usurario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID:";
            // 
            // cbEstadoAdmin
            // 
            this.cbEstadoAdmin.AutoSize = true;
            this.cbEstadoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoAdmin.Location = new System.Drawing.Point(278, 29);
            this.cbEstadoAdmin.Name = "cbEstadoAdmin";
            this.cbEstadoAdmin.Size = new System.Drawing.Size(69, 20);
            this.cbEstadoAdmin.TabIndex = 70;
            this.cbEstadoAdmin.Text = "Estado";
            this.cbEstadoAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvAdministrador
            // 
            this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrador.Location = new System.Drawing.Point(659, 85);
            this.dgvAdministrador.Name = "dgvAdministrador";
            this.dgvAdministrador.ReadOnly = true;
            this.dgvAdministrador.RowHeadersWidth = 51;
            this.dgvAdministrador.Size = new System.Drawing.Size(525, 836);
            this.dgvAdministrador.TabIndex = 81;
            this.dgvAdministrador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministrador_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblVentaServicios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 79);
            this.panel1.TabIndex = 80;
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVentaServicios.Location = new System.Drawing.Point(462, 21);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(295, 31);
            this.lblVentaServicios.TabIndex = 44;
            this.lblVentaServicios.Text = "ADMINISTRADORES";
            // 
            // CRUD_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.btnEditarAd);
            this.Controls.Add(this.btnHabilitarAd);
            this.Controls.Add(this.btnInhabilitarAd);
            this.Controls.Add(this.btnCrearAd);
            this.Controls.Add(this.gbAdministrador);
            this.Controls.Add(this.dgvAdministrador);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUD_Administrador";
            this.Text = "CRUD_Administrador";
            this.gbAdministrador.ResumeLayout(false);
            this.gbAdministrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditarAd;
        private System.Windows.Forms.Button btnHabilitarAd;
        private System.Windows.Forms.Button btnInhabilitarAd;
        private System.Windows.Forms.Button btnCrearAd;
        private System.Windows.Forms.GroupBox gbAdministrador;
        private System.Windows.Forms.Button btnActualizarAd;
        private System.Windows.Forms.TextBox txtPassAd;
        private System.Windows.Forms.Label lblPassAd;
        private System.Windows.Forms.Button btnCancelarAd;
        private System.Windows.Forms.Button btnAceptarAd;
        private System.Windows.Forms.TextBox txtUsuarioAd;
        private System.Windows.Forms.Label lblIDAdmin;
        private System.Windows.Forms.Label lblUsuarioAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEstadoAdmin;
        private System.Windows.Forms.DataGridView dgvAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentaServicios;
    }
}