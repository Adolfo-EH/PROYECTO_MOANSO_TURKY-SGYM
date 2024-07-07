namespace Turky_sGym_Programa
{
    partial class CRUD_Marca
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
            this.btnHabilitarM = new System.Windows.Forms.Button();
            this.btnInhabilitarM = new System.Windows.Forms.Button();
            this.btnCrearM = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.lblCategoriaM = new System.Windows.Forms.Label();
            this.cbxCategoriaM = new System.Windows.Forms.ComboBox();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnInsertarM = new System.Windows.Forms.Button();
            this.txtNomMarca = new System.Windows.Forms.TextBox();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoMarca = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.gbMarca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHabilitarM
            // 
            this.btnHabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarM.Location = new System.Drawing.Point(560, 362);
            this.btnHabilitarM.Name = "btnHabilitarM";
            this.btnHabilitarM.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitarM.TabIndex = 85;
            this.btnHabilitarM.Text = "HABILITAR";
            this.btnHabilitarM.UseVisualStyleBackColor = true;
            this.btnHabilitarM.Click += new System.EventHandler(this.btnHabilitarM_Click);
            // 
            // btnInhabilitarM
            // 
            this.btnInhabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarM.Location = new System.Drawing.Point(560, 461);
            this.btnInhabilitarM.Name = "btnInhabilitarM";
            this.btnInhabilitarM.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitarM.TabIndex = 83;
            this.btnInhabilitarM.Text = "INHABILITAR";
            this.btnInhabilitarM.UseVisualStyleBackColor = true;
            this.btnInhabilitarM.Click += new System.EventHandler(this.btnInhabilitarM_Click);
            // 
            // btnCrearM
            // 
            this.btnCrearM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearM.Location = new System.Drawing.Point(560, 267);
            this.btnCrearM.Name = "btnCrearM";
            this.btnCrearM.Size = new System.Drawing.Size(100, 50);
            this.btnCrearM.TabIndex = 82;
            this.btnCrearM.Text = "NUEVO";
            this.btnCrearM.UseVisualStyleBackColor = true;
            this.btnCrearM.Click += new System.EventHandler(this.btnCrearM_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(679, 85);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.Size = new System.Drawing.Size(505, 836);
            this.dgvMarca.TabIndex = 81;
            this.dgvMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellContentClick);
            this.dgvMarca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellDoubleClick);
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.lblCategoriaM);
            this.gbMarca.Controls.Add(this.cbxCategoriaM);
            this.gbMarca.Controls.Add(this.btnCancelarM);
            this.gbMarca.Controls.Add(this.btnInsertarM);
            this.gbMarca.Controls.Add(this.txtNomMarca);
            this.gbMarca.Controls.Add(this.lblIDMarca);
            this.gbMarca.Controls.Add(this.label1);
            this.gbMarca.Controls.Add(this.label2);
            this.gbMarca.Controls.Add(this.cbEstadoMarca);
            this.gbMarca.Location = new System.Drawing.Point(10, 91);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(650, 152);
            this.gbMarca.TabIndex = 84;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // lblCategoriaM
            // 
            this.lblCategoriaM.AutoSize = true;
            this.lblCategoriaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaM.Location = new System.Drawing.Point(53, 66);
            this.lblCategoriaM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaM.Name = "lblCategoriaM";
            this.lblCategoriaM.Size = new System.Drawing.Size(73, 17);
            this.lblCategoriaM.TabIndex = 90;
            this.lblCategoriaM.Text = "Categoría:";
            // 
            // cbxCategoriaM
            // 
            this.cbxCategoriaM.FormattingEnabled = true;
            this.cbxCategoriaM.Location = new System.Drawing.Point(133, 66);
            this.cbxCategoriaM.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoriaM.Name = "cbxCategoriaM";
            this.cbxCategoriaM.Size = new System.Drawing.Size(116, 21);
            this.cbxCategoriaM.TabIndex = 89;
            this.cbxCategoriaM.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaM_SelectedIndexChanged);
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Location = new System.Drawing.Point(550, 96);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(87, 45);
            this.btnCancelarM.TabIndex = 75;
            this.btnCancelarM.Text = "CANCELAR";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnInsertarM
            // 
            this.btnInsertarM.Location = new System.Drawing.Point(550, 16);
            this.btnInsertarM.Name = "btnInsertarM";
            this.btnInsertarM.Size = new System.Drawing.Size(87, 45);
            this.btnInsertarM.TabIndex = 73;
            this.btnInsertarM.Text = "INSERTAR";
            this.btnInsertarM.UseVisualStyleBackColor = true;
            this.btnInsertarM.Click += new System.EventHandler(this.btnInsertarM_Click);
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.Location = new System.Drawing.Point(133, 109);
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.Size = new System.Drawing.Size(217, 20);
            this.txtNomMarca.TabIndex = 69;
            this.txtNomMarca.TextChanged += new System.EventHandler(this.txtNomMarca_TextChanged);
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Location = new System.Drawing.Point(130, 32);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(19, 13);
            this.lblIDMarca.TabIndex = 72;
            this.lblIDMarca.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nombre Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID:";
            // 
            // cbEstadoMarca
            // 
            this.cbEstadoMarca.AutoSize = true;
            this.cbEstadoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoMarca.Location = new System.Drawing.Point(281, 66);
            this.cbEstadoMarca.Name = "cbEstadoMarca";
            this.cbEstadoMarca.Size = new System.Drawing.Size(69, 20);
            this.cbEstadoMarca.TabIndex = 70;
            this.cbEstadoMarca.Text = "Estado";
            this.cbEstadoMarca.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.f);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 79);
            this.panel1.TabIndex = 80;
            // 
            // f
            // 
            this.f.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.f.Location = new System.Drawing.Point(543, 21);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(117, 31);
            this.f.TabIndex = 44;
            this.f.Text = "MARCA";
            // 
            // CRUD_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.btnHabilitarM);
            this.Controls.Add(this.btnInhabilitarM);
            this.Controls.Add(this.btnCrearM);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.CRUD_Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHabilitarM;
        private System.Windows.Forms.Button btnInhabilitarM;
        private System.Windows.Forms.Button btnCrearM;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.Button btnCancelarM;
        private System.Windows.Forms.Button btnInsertarM;
        private System.Windows.Forms.TextBox txtNomMarca;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEstadoMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label lblCategoriaM;
        private System.Windows.Forms.ComboBox cbxCategoriaM;
    }
}