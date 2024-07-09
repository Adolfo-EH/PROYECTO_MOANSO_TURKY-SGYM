namespace Turky_sGym_Programa
{
    partial class CRUD_Categoría
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnCrearC = new System.Windows.Forms.Button();
            this.btnInhabilitarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCat = new System.Windows.Forms.TextBox();
            this.cbEstadoCategoría = new System.Windows.Forms.CheckBox();
            this.gbCategoría = new System.Windows.Forms.GroupBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnInsertarC = new System.Windows.Forms.Button();
            this.lblIDCat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHabilitarC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblVentaServicios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbCategoría.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(659, 85);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(525, 834);
            this.dgvCategoria.TabIndex = 65;
            this.dgvCategoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoría_CellContentDoubleClick);
            this.dgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            this.dgvCategoria.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategoria_CellMouseDoubleClick);
            // 
            // btnCrearC
            // 
            this.btnCrearC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearC.Location = new System.Drawing.Point(535, 266);
            this.btnCrearC.Name = "btnCrearC";
            this.btnCrearC.Size = new System.Drawing.Size(100, 50);
            this.btnCrearC.TabIndex = 66;
            this.btnCrearC.Text = "NUEVO";
            this.btnCrearC.UseVisualStyleBackColor = true;
            this.btnCrearC.Click += new System.EventHandler(this.btnCrearC_Click);
            // 
            // btnInhabilitarC
            // 
            this.btnInhabilitarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarC.Location = new System.Drawing.Point(535, 451);
            this.btnInhabilitarC.Name = "btnInhabilitarC";
            this.btnInhabilitarC.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitarC.TabIndex = 67;
            this.btnInhabilitarC.Text = "INHABILITAR";
            this.btnInhabilitarC.UseVisualStyleBackColor = true;
            this.btnInhabilitarC.Click += new System.EventHandler(this.btnInhabilitarC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nombre Categoría:";
            // 
            // txtNomCat
            // 
            this.txtNomCat.Location = new System.Drawing.Point(133, 67);
            this.txtNomCat.Name = "txtNomCat";
            this.txtNomCat.Size = new System.Drawing.Size(187, 20);
            this.txtNomCat.TabIndex = 69;
            // 
            // cbEstadoCategoría
            // 
            this.cbEstadoCategoría.AutoSize = true;
            this.cbEstadoCategoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCategoría.Location = new System.Drawing.Point(251, 29);
            this.cbEstadoCategoría.Name = "cbEstadoCategoría";
            this.cbEstadoCategoría.Size = new System.Drawing.Size(69, 20);
            this.cbEstadoCategoría.TabIndex = 70;
            this.cbEstadoCategoría.Text = "Estado";
            this.cbEstadoCategoría.UseVisualStyleBackColor = true;
            // 
            // gbCategoría
            // 
            this.gbCategoría.Controls.Add(this.btnCancelarC);
            this.gbCategoría.Controls.Add(this.btnInsertarC);
            this.gbCategoría.Controls.Add(this.txtNomCat);
            this.gbCategoría.Controls.Add(this.lblIDCat);
            this.gbCategoría.Controls.Add(this.label1);
            this.gbCategoría.Controls.Add(this.label2);
            this.gbCategoría.Controls.Add(this.cbEstadoCategoría);
            this.gbCategoría.Location = new System.Drawing.Point(12, 94);
            this.gbCategoría.Name = "gbCategoría";
            this.gbCategoría.Size = new System.Drawing.Size(641, 152);
            this.gbCategoría.TabIndex = 71;
            this.gbCategoría.TabStop = false;
            this.gbCategoría.Text = "Categoría";
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Location = new System.Drawing.Point(536, 91);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(87, 45);
            this.btnCancelarC.TabIndex = 75;
            this.btnCancelarC.Text = "CANCELAR";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            this.btnCancelarC.Click += new System.EventHandler(this.btnCancelarC_Click);
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Location = new System.Drawing.Point(536, 19);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(85, 45);
            this.btnInsertarC.TabIndex = 73;
            this.btnInsertarC.Text = "INSERTAR";
            this.btnInsertarC.UseVisualStyleBackColor = true;
            this.btnInsertarC.Click += new System.EventHandler(this.btnInsertarC_Click);
            // 
            // lblIDCat
            // 
            this.lblIDCat.AutoSize = true;
            this.lblIDCat.Location = new System.Drawing.Point(130, 32);
            this.lblIDCat.Name = "lblIDCat";
            this.lblIDCat.Size = new System.Drawing.Size(19, 13);
            this.lblIDCat.TabIndex = 72;
            this.lblIDCat.Text = "00";
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
            // btnHabilitarC
            // 
            this.btnHabilitarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarC.Location = new System.Drawing.Point(535, 357);
            this.btnHabilitarC.Name = "btnHabilitarC";
            this.btnHabilitarC.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitarC.TabIndex = 72;
            this.btnHabilitarC.Text = "HABILITAR";
            this.btnHabilitarC.UseVisualStyleBackColor = true;
            this.btnHabilitarC.Click += new System.EventHandler(this.btnHabilitarC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblVentaServicios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 80);
            this.panel1.TabIndex = 64;
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
            this.lblUsuario.TabIndex = 45;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVentaServicios.Location = new System.Drawing.Point(529, 24);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(184, 31);
            this.lblVentaServicios.TabIndex = 44;
            this.lblVentaServicios.Text = "CATEGORÍA";
            // 
            // CRUD_Categoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.btnHabilitarC);
            this.Controls.Add(this.btnInhabilitarC);
            this.Controls.Add(this.btnCrearC);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCategoría);
            this.Name = "CRUD_Categoría";
            this.Text = "CRUD_Categoría";
            this.Load += new System.EventHandler(this.CRUD_Categoría_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbCategoría.ResumeLayout(false);
            this.gbCategoría.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnCrearC;
        private System.Windows.Forms.Button btnInhabilitarC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCat;
        private System.Windows.Forms.CheckBox cbEstadoCategoría;
        private System.Windows.Forms.GroupBox gbCategoría;
        private System.Windows.Forms.Label lblIDCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarC;
        private System.Windows.Forms.Button btnHabilitarC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Label lblUsuario;
    }
}