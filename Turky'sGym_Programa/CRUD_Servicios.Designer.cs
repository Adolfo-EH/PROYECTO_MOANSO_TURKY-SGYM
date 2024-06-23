namespace Turky_sGym_Programa
{
    partial class CRUD_Servicios
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
            this.btnRegresarS = new System.Windows.Forms.Button();
            this.btnHabilitarS = new System.Windows.Forms.Button();
            this.btnInhabilitarS = new System.Windows.Forms.Button();
            this.btnCrearS = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.btnCancelarS = new System.Windows.Forms.Button();
            this.btnInsertarS = new System.Windows.Forms.Button();
            this.txtNomSer = new System.Windows.Forms.TextBox();
            this.lblIDSer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoServicio = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.gbServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblVentaServicios);
            this.panel1.Location = new System.Drawing.Point(-143, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 69);
            this.panel1.TabIndex = 64;
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVentaServicios.Location = new System.Drawing.Point(526, 24);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(172, 31);
            this.lblVentaServicios.TabIndex = 44;
            this.lblVentaServicios.Text = "SERVICIOS";
            this.lblVentaServicios.Click += new System.EventHandler(this.lblVentaServicios_Click);
            // 
            // btnRegresarS
            // 
            this.btnRegresarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarS.Location = new System.Drawing.Point(721, 303);
            this.btnRegresarS.Name = "btnRegresarS";
            this.btnRegresarS.Size = new System.Drawing.Size(143, 38);
            this.btnRegresarS.TabIndex = 79;
            this.btnRegresarS.Text = "REGRESAR";
            this.btnRegresarS.UseVisualStyleBackColor = true;
            // 
            // btnHabilitarS
            // 
            this.btnHabilitarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarS.Location = new System.Drawing.Point(721, 237);
            this.btnHabilitarS.Name = "btnHabilitarS";
            this.btnHabilitarS.Size = new System.Drawing.Size(143, 38);
            this.btnHabilitarS.TabIndex = 78;
            this.btnHabilitarS.Text = "HABILITAR";
            this.btnHabilitarS.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarS
            // 
            this.btnInhabilitarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarS.Location = new System.Drawing.Point(721, 172);
            this.btnInhabilitarS.Name = "btnInhabilitarS";
            this.btnInhabilitarS.Size = new System.Drawing.Size(143, 38);
            this.btnInhabilitarS.TabIndex = 76;
            this.btnInhabilitarS.Text = "INHABILITAR";
            this.btnInhabilitarS.UseVisualStyleBackColor = true;
            // 
            // btnCrearS
            // 
            this.btnCrearS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearS.Location = new System.Drawing.Point(721, 106);
            this.btnCrearS.Name = "btnCrearS";
            this.btnCrearS.Size = new System.Drawing.Size(143, 38);
            this.btnCrearS.TabIndex = 75;
            this.btnCrearS.Text = "CREAR";
            this.btnCrearS.UseVisualStyleBackColor = true;
            this.btnCrearS.Click += new System.EventHandler(this.btnCrearS_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(28, 106);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(641, 296);
            this.dgvServicios.TabIndex = 74;
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.btnCancelarS);
            this.gbServicio.Controls.Add(this.btnInsertarS);
            this.gbServicio.Controls.Add(this.txtNomSer);
            this.gbServicio.Controls.Add(this.lblIDSer);
            this.gbServicio.Controls.Add(this.label1);
            this.gbServicio.Controls.Add(this.label2);
            this.gbServicio.Controls.Add(this.cbEstadoServicio);
            this.gbServicio.Location = new System.Drawing.Point(28, 429);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(641, 152);
            this.gbServicio.TabIndex = 77;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Servicio";
            // 
            // btnCancelarS
            // 
            this.btnCancelarS.Location = new System.Drawing.Point(503, 90);
            this.btnCancelarS.Name = "btnCancelarS";
            this.btnCancelarS.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarS.TabIndex = 75;
            this.btnCancelarS.Text = "CANCELAR";
            this.btnCancelarS.UseVisualStyleBackColor = true;
            // 
            // btnInsertarS
            // 
            this.btnInsertarS.Location = new System.Drawing.Point(503, 29);
            this.btnInsertarS.Name = "btnInsertarS";
            this.btnInsertarS.Size = new System.Drawing.Size(115, 40);
            this.btnInsertarS.TabIndex = 73;
            this.btnInsertarS.Text = "INSERTAR";
            this.btnInsertarS.UseVisualStyleBackColor = true;
            // 
            // txtNomSer
            // 
            this.txtNomSer.Location = new System.Drawing.Point(133, 67);
            this.txtNomSer.Name = "txtNomSer";
            this.txtNomSer.Size = new System.Drawing.Size(187, 20);
            this.txtNomSer.TabIndex = 69;
            // 
            // lblIDSer
            // 
            this.lblIDSer.AutoSize = true;
            this.lblIDSer.Location = new System.Drawing.Point(130, 32);
            this.lblIDSer.Name = "lblIDSer";
            this.lblIDSer.Size = new System.Drawing.Size(19, 13);
            this.lblIDSer.TabIndex = 72;
            this.lblIDSer.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nombre Servicio:";
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
            // cbEstadoServicio
            // 
            this.cbEstadoServicio.AutoSize = true;
            this.cbEstadoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoServicio.Location = new System.Drawing.Point(251, 29);
            this.cbEstadoServicio.Name = "cbEstadoServicio";
            this.cbEstadoServicio.Size = new System.Drawing.Size(69, 20);
            this.cbEstadoServicio.TabIndex = 70;
            this.cbEstadoServicio.Text = "Estado";
            this.cbEstadoServicio.UseVisualStyleBackColor = true;
            // 
            // CRUD_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 630);
            this.Controls.Add(this.btnRegresarS);
            this.Controls.Add(this.btnHabilitarS);
            this.Controls.Add(this.btnInhabilitarS);
            this.Controls.Add(this.btnCrearS);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.gbServicio);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Servicios";
            this.Text = "CRUD_Servicios";
            this.Load += new System.EventHandler(this.CRUD_Servicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.Button btnRegresarS;
        private System.Windows.Forms.Button btnHabilitarS;
        private System.Windows.Forms.Button btnInhabilitarS;
        private System.Windows.Forms.Button btnCrearS;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Button btnCancelarS;
        private System.Windows.Forms.Button btnInsertarS;
        private System.Windows.Forms.TextBox txtNomSer;
        private System.Windows.Forms.Label lblIDSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEstadoServicio;
    }
}