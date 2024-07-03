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
            this.btnRegresarM = new System.Windows.Forms.Button();
            this.btnHabilitarM = new System.Windows.Forms.Button();
            this.btnInhabilitarM = new System.Windows.Forms.Button();
            this.btnCrearM = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnInsertarM = new System.Windows.Forms.Button();
            this.txtNomMarca = new System.Windows.Forms.TextBox();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoMarca = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Label();
            this.lblCategoriaM = new System.Windows.Forms.Label();
            this.cbxCategoriaM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.gbMarca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresarM
            // 
            this.btnRegresarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarM.Location = new System.Drawing.Point(1155, 729);
            this.btnRegresarM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresarM.Name = "btnRegresarM";
            this.btnRegresarM.Size = new System.Drawing.Size(191, 47);
            this.btnRegresarM.TabIndex = 86;
            this.btnRegresarM.Text = "REGRESAR";
            this.btnRegresarM.UseVisualStyleBackColor = true;
            // 
            // btnHabilitarM
            // 
            this.btnHabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarM.Location = new System.Drawing.Point(1155, 267);
            this.btnHabilitarM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHabilitarM.Name = "btnHabilitarM";
            this.btnHabilitarM.Size = new System.Drawing.Size(191, 47);
            this.btnHabilitarM.TabIndex = 85;
            this.btnHabilitarM.Text = "HABILITAR";
            this.btnHabilitarM.UseVisualStyleBackColor = true;
            this.btnHabilitarM.Click += new System.EventHandler(this.btnHabilitarM_Click);
            // 
            // btnInhabilitarM
            // 
            this.btnInhabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarM.Location = new System.Drawing.Point(1155, 351);
            this.btnInhabilitarM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInhabilitarM.Name = "btnInhabilitarM";
            this.btnInhabilitarM.Size = new System.Drawing.Size(191, 47);
            this.btnInhabilitarM.TabIndex = 83;
            this.btnInhabilitarM.Text = "INHABILITAR";
            this.btnInhabilitarM.UseVisualStyleBackColor = true;
            this.btnInhabilitarM.Click += new System.EventHandler(this.btnInhabilitarM_Click);
            // 
            // btnCrearM
            // 
            this.btnCrearM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearM.Location = new System.Drawing.Point(1155, 191);
            this.btnCrearM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearM.Name = "btnCrearM";
            this.btnCrearM.Size = new System.Drawing.Size(191, 47);
            this.btnCrearM.TabIndex = 82;
            this.btnCrearM.Text = "NUEVO";
            this.btnCrearM.UseVisualStyleBackColor = true;
            this.btnCrearM.Click += new System.EventHandler(this.btnCrearM_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(231, 191);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.Size = new System.Drawing.Size(855, 364);
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
            this.gbMarca.Location = new System.Drawing.Point(231, 588);
            this.gbMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMarca.Size = new System.Drawing.Size(855, 187);
            this.gbMarca.TabIndex = 84;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Location = new System.Drawing.Point(671, 111);
            this.btnCancelarM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(153, 43);
            this.btnCancelarM.TabIndex = 75;
            this.btnCancelarM.Text = "CANCELAR";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnInsertarM
            // 
            this.btnInsertarM.Location = new System.Drawing.Point(671, 36);
            this.btnInsertarM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertarM.Name = "btnInsertarM";
            this.btnInsertarM.Size = new System.Drawing.Size(153, 49);
            this.btnInsertarM.TabIndex = 73;
            this.btnInsertarM.Text = "INSERTAR";
            this.btnInsertarM.UseVisualStyleBackColor = true;
            this.btnInsertarM.Click += new System.EventHandler(this.btnInsertarM_Click);
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.Location = new System.Drawing.Point(180, 139);
            this.txtNomMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.Size = new System.Drawing.Size(248, 22);
            this.txtNomMarca.TabIndex = 69;
            this.txtNomMarca.TextChanged += new System.EventHandler(this.txtNomMarca_TextChanged);
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Location = new System.Drawing.Point(173, 39);
            this.lblIDMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(21, 16);
            this.lblIDMarca.TabIndex = 72;
            this.lblIDMarca.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nombre Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID:";
            // 
            // cbEstadoMarca
            // 
            this.cbEstadoMarca.AutoSize = true;
            this.cbEstadoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoMarca.Location = new System.Drawing.Point(335, 36);
            this.cbEstadoMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstadoMarca.Name = "cbEstadoMarca";
            this.cbEstadoMarca.Size = new System.Drawing.Size(83, 24);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 97);
            this.panel1.TabIndex = 80;
            // 
            // f
            // 
            this.f.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.f.Location = new System.Drawing.Point(684, 26);
            this.f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(146, 39);
            this.f.TabIndex = 44;
            this.f.Text = "MARCA";
            // 
            // lblCategoriaM
            // 
            this.lblCategoriaM.AutoSize = true;
            this.lblCategoriaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaM.Location = new System.Drawing.Point(74, 94);
            this.lblCategoriaM.Name = "lblCategoriaM";
            this.lblCategoriaM.Size = new System.Drawing.Size(86, 20);
            this.lblCategoriaM.TabIndex = 90;
            this.lblCategoriaM.Text = "Categoría:";
            // 
            // cbxCategoriaM
            // 
            this.cbxCategoriaM.FormattingEnabled = true;
            this.cbxCategoriaM.Location = new System.Drawing.Point(180, 94);
            this.cbxCategoriaM.Name = "cbxCategoriaM";
            this.cbxCategoriaM.Size = new System.Drawing.Size(98, 24);
            this.cbxCategoriaM.TabIndex = 89;
            this.cbxCategoriaM.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaM_SelectedIndexChanged);
            // 
            // CRUD_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 811);
            this.Controls.Add(this.btnRegresarM);
            this.Controls.Add(this.btnHabilitarM);
            this.Controls.Add(this.btnInhabilitarM);
            this.Controls.Add(this.btnCrearM);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Button btnRegresarM;
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