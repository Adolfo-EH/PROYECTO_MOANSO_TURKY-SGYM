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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVentaServicios = new System.Windows.Forms.Label();
            this.dgvCategoría = new System.Windows.Forms.DataGridView();
            this.btnCrearC = new System.Windows.Forms.Button();
            this.btnInhabilitarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCat = new System.Windows.Forms.TextBox();
            this.cbEstadoCategoría = new System.Windows.Forms.CheckBox();
            this.gbCategoría = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIDCat = new System.Windows.Forms.Label();
            this.btnInsertarC = new System.Windows.Forms.Button();
            this.btnHabilitarC = new System.Windows.Forms.Button();
            this.btnRegresarC = new System.Windows.Forms.Button();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoría)).BeginInit();
            this.gbCategoría.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblVentaServicios);
            this.panel1.Location = new System.Drawing.Point(-117, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 71);
            this.panel1.TabIndex = 64;
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVentaServicios.Location = new System.Drawing.Point(486, 20);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(184, 31);
            this.lblVentaServicios.TabIndex = 44;
            this.lblVentaServicios.Text = "CATEGORÍA";
            // 
            // dgvCategoría
            // 
            this.dgvCategoría.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoría.Location = new System.Drawing.Point(24, 91);
            this.dgvCategoría.Name = "dgvCategoría";
            this.dgvCategoría.Size = new System.Drawing.Size(641, 296);
            this.dgvCategoría.TabIndex = 65;
            // 
            // btnCrearC
            // 
            this.btnCrearC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearC.Location = new System.Drawing.Point(717, 91);
            this.btnCrearC.Name = "btnCrearC";
            this.btnCrearC.Size = new System.Drawing.Size(143, 38);
            this.btnCrearC.TabIndex = 66;
            this.btnCrearC.Text = "CREAR";
            this.btnCrearC.UseVisualStyleBackColor = true;
            this.btnCrearC.Click += new System.EventHandler(this.btnCrearC_Click);
            // 
            // btnInhabilitarC
            // 
            this.btnInhabilitarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarC.Location = new System.Drawing.Point(717, 157);
            this.btnInhabilitarC.Name = "btnInhabilitarC";
            this.btnInhabilitarC.Size = new System.Drawing.Size(143, 38);
            this.btnInhabilitarC.TabIndex = 67;
            this.btnInhabilitarC.Text = "INHABILITAR";
            this.btnInhabilitarC.UseVisualStyleBackColor = true;
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
            this.gbCategoría.Location = new System.Drawing.Point(24, 414);
            this.gbCategoría.Name = "gbCategoría";
            this.gbCategoría.Size = new System.Drawing.Size(641, 152);
            this.gbCategoría.TabIndex = 71;
            this.gbCategoría.TabStop = false;
            this.gbCategoría.Text = "Categoría";
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
            // lblIDCat
            // 
            this.lblIDCat.AutoSize = true;
            this.lblIDCat.Location = new System.Drawing.Point(130, 32);
            this.lblIDCat.Name = "lblIDCat";
            this.lblIDCat.Size = new System.Drawing.Size(19, 13);
            this.lblIDCat.TabIndex = 72;
            this.lblIDCat.Text = "00";
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Location = new System.Drawing.Point(503, 29);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(115, 40);
            this.btnInsertarC.TabIndex = 73;
            this.btnInsertarC.Text = "INSERTAR";
            this.btnInsertarC.UseVisualStyleBackColor = true;
            // 
            // btnHabilitarC
            // 
            this.btnHabilitarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarC.Location = new System.Drawing.Point(717, 222);
            this.btnHabilitarC.Name = "btnHabilitarC";
            this.btnHabilitarC.Size = new System.Drawing.Size(143, 38);
            this.btnHabilitarC.TabIndex = 72;
            this.btnHabilitarC.Text = "HABILITAR";
            this.btnHabilitarC.UseVisualStyleBackColor = true;
            // 
            // btnRegresarC
            // 
            this.btnRegresarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarC.Location = new System.Drawing.Point(717, 288);
            this.btnRegresarC.Name = "btnRegresarC";
            this.btnRegresarC.Size = new System.Drawing.Size(143, 38);
            this.btnRegresarC.TabIndex = 73;
            this.btnRegresarC.Text = "REGRESAR";
            this.btnRegresarC.UseVisualStyleBackColor = true;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Location = new System.Drawing.Point(503, 90);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarC.TabIndex = 75;
            this.btnCancelarC.Text = "CANCELAR";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            // 
            // CRUD_Categoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 588);
            this.Controls.Add(this.btnRegresarC);
            this.Controls.Add(this.btnHabilitarC);
            this.Controls.Add(this.btnInhabilitarC);
            this.Controls.Add(this.btnCrearC);
            this.Controls.Add(this.dgvCategoría);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCategoría);
            this.Name = "CRUD_Categoría";
            this.Text = "CRUD_Categoría";
            this.Load += new System.EventHandler(this.CRUD_Categoría_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoría)).EndInit();
            this.gbCategoría.ResumeLayout(false);
            this.gbCategoría.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.DataGridView dgvCategoría;
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
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnRegresarC;
    }
}