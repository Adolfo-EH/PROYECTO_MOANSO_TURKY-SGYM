namespace Turky_sGym_Programa
{
    partial class Consulta_Servicio_Cliente
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
            this.btnBuscarVentaServicio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegresarVS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 68);
            this.panel1.TabIndex = 15;
            // 
            // btnBuscarVentaServicio
            // 
            this.btnBuscarVentaServicio.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscarVentaServicio.BackgroundImage = global::Turky_sGym_Programa.Properties.Resources.lupa__1___2_;
            this.btnBuscarVentaServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarVentaServicio.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentaServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentaServicio.Location = new System.Drawing.Point(228, 107);
            this.btnBuscarVentaServicio.Name = "btnBuscarVentaServicio";
            this.btnBuscarVentaServicio.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarVentaServicio.TabIndex = 12;
            this.btnBuscarVentaServicio.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 288);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(71, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnRegresarVS
            // 
            this.btnRegresarVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarVS.Location = new System.Drawing.Point(99, 366);
            this.btnRegresarVS.Name = "btnRegresarVS";
            this.btnRegresarVS.Size = new System.Drawing.Size(93, 29);
            this.btnRegresarVS.TabIndex = 11;
            this.btnRegresarVS.Text = "Regresar";
            this.btnRegresarVS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busqueda de Ventas por DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Consulta_Servicio_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarVentaServicio);
            this.Controls.Add(this.btnRegresarVS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Consulta_Servicio_Cliente";
            this.Text = "Consulta_Servicio_Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarVentaServicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegresarVS;
        private System.Windows.Forms.Label label1;
    }
}