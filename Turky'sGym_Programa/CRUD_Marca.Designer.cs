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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.gbMarca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresarM
            // 
            this.btnRegresarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarM.Location = new System.Drawing.Point(740, 299);
            this.btnRegresarM.Name = "btnRegresarM";
            this.btnRegresarM.Size = new System.Drawing.Size(143, 38);
            this.btnRegresarM.TabIndex = 86;
            this.btnRegresarM.Text = "REGRESAR";
            this.btnRegresarM.UseVisualStyleBackColor = true;
            // 
            // btnHabilitarM
            // 
            this.btnHabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarM.Location = new System.Drawing.Point(740, 233);
            this.btnHabilitarM.Name = "btnHabilitarM";
            this.btnHabilitarM.Size = new System.Drawing.Size(143, 38);
            this.btnHabilitarM.TabIndex = 85;
            this.btnHabilitarM.Text = "HABILITAR";
            this.btnHabilitarM.UseVisualStyleBackColor = true;
            this.btnHabilitarM.Click += new System.EventHandler(this.btnHabilitarM_Click);
            // 
            // btnInhabilitarM
            // 
            this.btnInhabilitarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarM.Location = new System.Drawing.Point(740, 168);
            this.btnInhabilitarM.Name = "btnInhabilitarM";
            this.btnInhabilitarM.Size = new System.Drawing.Size(143, 38);
            this.btnInhabilitarM.TabIndex = 83;
            this.btnInhabilitarM.Text = "INHABILITAR";
            this.btnInhabilitarM.UseVisualStyleBackColor = true;
            this.btnInhabilitarM.Click += new System.EventHandler(this.btnInhabilitarM_Click);
            // 
            // btnCrearM
            // 
            this.btnCrearM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearM.Location = new System.Drawing.Point(740, 102);
            this.btnCrearM.Name = "btnCrearM";
            this.btnCrearM.Size = new System.Drawing.Size(143, 38);
            this.btnCrearM.TabIndex = 82;
            this.btnCrearM.Text = "CREAR";
            this.btnCrearM.UseVisualStyleBackColor = true;
            this.btnCrearM.Click += new System.EventHandler(this.btnCrearM_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(47, 102);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(641, 296);
            this.dgvMarca.TabIndex = 81;
            this.dgvMarca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellDoubleClick);
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.btnCancelarM);
            this.gbMarca.Controls.Add(this.btnInsertarM);
            this.gbMarca.Controls.Add(this.txtNomMarca);
            this.gbMarca.Controls.Add(this.lblIDMarca);
            this.gbMarca.Controls.Add(this.label1);
            this.gbMarca.Controls.Add(this.label2);
            this.gbMarca.Controls.Add(this.cbEstadoMarca);
            this.gbMarca.Location = new System.Drawing.Point(47, 425);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(641, 152);
            this.gbMarca.TabIndex = 84;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Location = new System.Drawing.Point(503, 90);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarM.TabIndex = 75;
            this.btnCancelarM.Text = "CANCELAR";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnInsertarM
            // 
            this.btnInsertarM.Location = new System.Drawing.Point(503, 29);
            this.btnInsertarM.Name = "btnInsertarM";
            this.btnInsertarM.Size = new System.Drawing.Size(115, 40);
            this.btnInsertarM.TabIndex = 73;
            this.btnInsertarM.Text = "INSERTAR";
            this.btnInsertarM.UseVisualStyleBackColor = true;
            this.btnInsertarM.Click += new System.EventHandler(this.btnInsertarM_Click);
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.Location = new System.Drawing.Point(133, 67);
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.Size = new System.Drawing.Size(187, 20);
            this.txtNomMarca.TabIndex = 69;
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
            this.label1.Location = new System.Drawing.Point(24, 68);
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
            this.cbEstadoMarca.Location = new System.Drawing.Point(251, 29);
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
            this.panel1.Location = new System.Drawing.Point(-94, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 69);
            this.panel1.TabIndex = 80;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.f.Location = new System.Drawing.Point(464, 21);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(117, 31);
            this.f.TabIndex = 44;
            this.f.Text = "MARCA";
            // 
            // CRUD_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 631);
            this.Controls.Add(this.btnRegresarM);
            this.Controls.Add(this.btnHabilitarM);
            this.Controls.Add(this.btnInhabilitarM);
            this.Controls.Add(this.btnCrearM);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
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
    }
}