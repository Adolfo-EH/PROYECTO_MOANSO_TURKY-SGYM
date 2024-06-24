namespace Turky_sGym_Programa
{
    partial class CSLT_Venta_Planes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresarVS = new System.Windows.Forms.Button();
            this.txbDNI_Consulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsultaPlanes = new System.Windows.Forms.DataGridView();
            this.btnBuscarVentaServicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-17, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 66);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busqueda de Ventas por DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresarVS
            // 
            this.btnRegresarVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVS.Location = new System.Drawing.Point(100, 346);
            this.btnRegresarVS.Name = "btnRegresarVS";
            this.btnRegresarVS.Size = new System.Drawing.Size(93, 29);
            this.btnRegresarVS.TabIndex = 19;
            this.btnRegresarVS.Text = "Regresar";
            this.btnRegresarVS.UseVisualStyleBackColor = true;
            // 
            // txbDNI_Consulta
            // 
            this.txbDNI_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDNI_Consulta.Location = new System.Drawing.Point(72, 87);
            this.txbDNI_Consulta.Name = "txbDNI_Consulta";
            this.txbDNI_Consulta.Size = new System.Drawing.Size(177, 20);
            this.txbDNI_Consulta.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "DNI:";
            // 
            // dgvConsultaPlanes
            // 
            this.dgvConsultaPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPlanes.Location = new System.Drawing.Point(314, 87);
            this.dgvConsultaPlanes.Name = "dgvConsultaPlanes";
            this.dgvConsultaPlanes.Size = new System.Drawing.Size(474, 288);
            this.dgvConsultaPlanes.TabIndex = 16;
            // 
            // btnBuscarVentaServicio
            // 
            this.btnBuscarVentaServicio.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscarVentaServicio.BackgroundImage = global::Turky_sGym_Programa.Properties.Resources.lupa__1___2_;
            this.btnBuscarVentaServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarVentaServicio.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentaServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentaServicio.Location = new System.Drawing.Point(229, 87);
            this.btnBuscarVentaServicio.Name = "btnBuscarVentaServicio";
            this.btnBuscarVentaServicio.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarVentaServicio.TabIndex = 20;
            this.btnBuscarVentaServicio.UseVisualStyleBackColor = false;
            // 
            // CSLT_Venta_Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarVentaServicio);
            this.Controls.Add(this.btnRegresarVS);
            this.Controls.Add(this.txbDNI_Consulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsultaPlanes);
            this.Name = "CSLT_Venta_Planes";
            this.Text = "CSLT_Venta_Servicios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarVentaServicio;
        private System.Windows.Forms.Button btnRegresarVS;
        private System.Windows.Forms.TextBox txbDNI_Consulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsultaPlanes;
    }
}