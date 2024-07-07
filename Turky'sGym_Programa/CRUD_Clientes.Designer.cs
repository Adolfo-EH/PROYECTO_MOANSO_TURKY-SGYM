namespace Turky_sGym_Programa
{
    partial class CRUD_Clientes
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitarCli = new System.Windows.Forms.Button();
            this.btnHabilitarCli = new System.Windows.Forms.Button();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grbDatCli = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDNICli = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxestCli = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbDatCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 79);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(504, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "CLIENTES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(762, 563);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 41);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(762, 766);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 41);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitarCli
            // 
            this.btnDeshabilitarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarCli.Location = new System.Drawing.Point(762, 702);
            this.btnDeshabilitarCli.Name = "btnDeshabilitarCli";
            this.btnDeshabilitarCli.Size = new System.Drawing.Size(115, 41);
            this.btnDeshabilitarCli.TabIndex = 49;
            this.btnDeshabilitarCli.Text = "DESHABILITAR";
            this.btnDeshabilitarCli.UseVisualStyleBackColor = true;
            this.btnDeshabilitarCli.Click += new System.EventHandler(this.btnDeshabilitarCli_Click);
            // 
            // btnHabilitarCli
            // 
            this.btnHabilitarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarCli.Location = new System.Drawing.Point(762, 631);
            this.btnHabilitarCli.Name = "btnHabilitarCli";
            this.btnHabilitarCli.Size = new System.Drawing.Size(115, 41);
            this.btnHabilitarCli.TabIndex = 48;
            this.btnHabilitarCli.Text = "HABILITAR";
            this.btnHabilitarCli.UseVisualStyleBackColor = true;
            this.btnHabilitarCli.Click += new System.EventHandler(this.btnHabilitarCli_Click);
            // 
            // btnNuevoCli
            // 
            this.btnNuevoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCli.Location = new System.Drawing.Point(762, 490);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(115, 41);
            this.btnNuevoCli.TabIndex = 47;
            this.btnNuevoCli.Text = "NUEVO";
            this.btnNuevoCli.UseVisualStyleBackColor = true;
            this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(118, 127);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(947, 330);
            this.dgvClientes.TabIndex = 45;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // grbDatCli
            // 
            this.grbDatCli.Controls.Add(this.btnModificar);
            this.grbDatCli.Controls.Add(this.txtDNICli);
            this.grbDatCli.Controls.Add(this.btnCancelar);
            this.grbDatCli.Controls.Add(this.btnGuardar);
            this.grbDatCli.Controls.Add(this.cbxestCli);
            this.grbDatCli.Controls.Add(this.label6);
            this.grbDatCli.Controls.Add(this.label4);
            this.grbDatCli.Controls.Add(this.txtTelCli);
            this.grbDatCli.Controls.Add(this.label3);
            this.grbDatCli.Controls.Add(this.dtpFecNac);
            this.grbDatCli.Controls.Add(this.label2);
            this.grbDatCli.Controls.Add(this.txtnomCli);
            this.grbDatCli.Controls.Add(this.label1);
            this.grbDatCli.Location = new System.Drawing.Point(213, 485);
            this.grbDatCli.Name = "grbDatCli";
            this.grbDatCli.Size = new System.Drawing.Size(526, 322);
            this.grbDatCli.TabIndex = 46;
            this.grbDatCli.TabStop = false;
            this.grbDatCli.Text = "DATOS CLIENTE";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(386, 160);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 38);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDNICli
            // 
            this.txtDNICli.Location = new System.Drawing.Point(168, 100);
            this.txtDNICli.Name = "txtDNICli";
            this.txtDNICli.Size = new System.Drawing.Size(199, 20);
            this.txtDNICli.TabIndex = 50;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(386, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 38);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(386, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 38);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxestCli
            // 
            this.cbxestCli.AutoSize = true;
            this.cbxestCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestCli.Location = new System.Drawing.Point(167, 61);
            this.cbxestCli.Name = "cbxestCli";
            this.cbxestCli.Size = new System.Drawing.Size(113, 20);
            this.cbxestCli.TabIndex = 48;
            this.cbxestCli.Text = "Estado Cliente";
            this.cbxestCli.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "DNI:";
            // 
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(167, 238);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(200, 20);
            this.txtTelCli.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Teléfono:";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(167, 190);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecNac.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha Nacimiento:";
            // 
            // txtnomCli
            // 
            this.txtnomCli.Location = new System.Drawing.Point(167, 146);
            this.txtnomCli.Name = "txtnomCli";
            this.txtnomCli.Size = new System.Drawing.Size(200, 20);
            this.txtnomCli.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Cliente:";
            // 
            // CRUD_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 854);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitarCli);
            this.Controls.Add(this.btnHabilitarCli);
            this.Controls.Add(this.btnNuevoCli);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grbDatCli);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Clientes";
            this.Text = "CRUD_Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbDatCli.ResumeLayout(false);
            this.grbDatCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitarCli;
        private System.Windows.Forms.Button btnHabilitarCli;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grbDatCli;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDNICli;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbxestCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomCli;
        private System.Windows.Forms.Label label1;
    }
}