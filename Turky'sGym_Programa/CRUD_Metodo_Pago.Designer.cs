namespace Turky_sGym_Programa
{
    partial class CRUD_Metodo_Pago
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
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupMetodo = new System.Windows.Forms.GroupBox();
            this.cmbTipoMetPag = new System.Windows.Forms.ComboBox();
            this.cbxEstadoMetodoPago = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupMetodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(472, 506);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitar.TabIndex = 34;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(472, 403);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitar.TabIndex = 33;
            this.btnHabilitar.Text = "HABILITAR";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(472, 312);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 50);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupMetodo
            // 
            this.groupMetodo.Controls.Add(this.cmbTipoMetPag);
            this.groupMetodo.Controls.Add(this.cbxEstadoMetodoPago);
            this.groupMetodo.Controls.Add(this.btnCancelar);
            this.groupMetodo.Controls.Add(this.btnInsertar);
            this.groupMetodo.Controls.Add(this.txtNombre);
            this.groupMetodo.Controls.Add(this.lbID);
            this.groupMetodo.Controls.Add(this.label3);
            this.groupMetodo.Controls.Add(this.label2);
            this.groupMetodo.Controls.Add(this.label1);
            this.groupMetodo.Location = new System.Drawing.Point(12, 99);
            this.groupMetodo.Name = "groupMetodo";
            this.groupMetodo.Size = new System.Drawing.Size(560, 176);
            this.groupMetodo.TabIndex = 31;
            this.groupMetodo.TabStop = false;
            this.groupMetodo.Text = "Datos de Método de Pago";
            // 
            // cmbTipoMetPag
            // 
            this.cmbTipoMetPag.FormattingEnabled = true;
            this.cmbTipoMetPag.Location = new System.Drawing.Point(59, 117);
            this.cmbTipoMetPag.Name = "cmbTipoMetPag";
            this.cmbTipoMetPag.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMetPag.TabIndex = 31;
            this.cmbTipoMetPag.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMetPag_SelectedIndexChanged);
            // 
            // cbxEstadoMetodoPago
            // 
            this.cbxEstadoMetodoPago.AutoSize = true;
            this.cbxEstadoMetodoPago.Location = new System.Drawing.Point(292, 67);
            this.cbxEstadoMetodoPago.Name = "cbxEstadoMetodoPago";
            this.cbxEstadoMetodoPago.Size = new System.Drawing.Size(62, 17);
            this.cbxEstadoMetodoPago.TabIndex = 30;
            this.cbxEstadoMetodoPago.Text = "Estado ";
            this.cbxEstadoMetodoPago.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(454, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 45);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(454, 26);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(87, 45);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(56, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodoPago.Location = new System.Drawing.Point(589, 85);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.ReadOnly = true;
            this.dgvMetodoPago.Size = new System.Drawing.Size(595, 824);
            this.dgvMetodoPago.TabIndex = 30;
            this.dgvMetodoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodoPago_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 79);
            this.panel1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(460, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "MÉTODO DE PAGO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(924, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(103, 29);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Usuario";
            // 
            // CRUD_Metodo_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupMetodo);
            this.Controls.Add(this.dgvMetodoPago);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Metodo_Pago";
            this.Text = "CRUD_Metodo_Pago";
            this.Load += new System.EventHandler(this.CRUD_Metodo_Pago_Load);
            this.groupMetodo.ResumeLayout(false);
            this.groupMetodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupMetodo;
        private System.Windows.Forms.CheckBox cbxEstadoMetodoPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoMetPag;
        private System.Windows.Forms.Label lblUsuario;
    }
}