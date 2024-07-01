namespace Turky_sGym_Programa
{
    partial class CRUD_Forma_Pago
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
            this.btnRegresarFP = new System.Windows.Forms.Button();
            this.btnInhabilitarFP = new System.Windows.Forms.Button();
            this.btnHabilitarFP = new System.Windows.Forms.Button();
            this.btnNuevoFP = new System.Windows.Forms.Button();
            this.groupForma = new System.Windows.Forms.GroupBox();
            this.cbxEstadoFP = new System.Windows.Forms.CheckBox();
            this.btnCancelarFP = new System.Windows.Forms.Button();
            this.btnInsertarFP = new System.Windows.Forms.Button();
            this.lbIDFP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFormaPago = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoFP = new System.Windows.Forms.TextBox();
            this.groupForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresarFP
            // 
            this.btnRegresarFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarFP.Location = new System.Drawing.Point(614, 406);
            this.btnRegresarFP.Name = "btnRegresarFP";
            this.btnRegresarFP.Size = new System.Drawing.Size(100, 50);
            this.btnRegresarFP.TabIndex = 42;
            this.btnRegresarFP.Text = "Regresar";
            this.btnRegresarFP.UseVisualStyleBackColor = true;
            this.btnRegresarFP.Click += new System.EventHandler(this.btnRegresarFP_Click);
            // 
            // btnInhabilitarFP
            // 
            this.btnInhabilitarFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarFP.Location = new System.Drawing.Point(614, 258);
            this.btnInhabilitarFP.Name = "btnInhabilitarFP";
            this.btnInhabilitarFP.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitarFP.TabIndex = 41;
            this.btnInhabilitarFP.Text = "Inhabilitar";
            this.btnInhabilitarFP.UseVisualStyleBackColor = true;
            this.btnInhabilitarFP.Click += new System.EventHandler(this.btnInhabilitarFP_Click);
            // 
            // btnHabilitarFP
            // 
            this.btnHabilitarFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarFP.Location = new System.Drawing.Point(614, 182);
            this.btnHabilitarFP.Name = "btnHabilitarFP";
            this.btnHabilitarFP.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitarFP.TabIndex = 40;
            this.btnHabilitarFP.Text = "Habilitar";
            this.btnHabilitarFP.UseVisualStyleBackColor = true;
            this.btnHabilitarFP.Click += new System.EventHandler(this.btnHabilitarFP_Click);
            // 
            // btnNuevoFP
            // 
            this.btnNuevoFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoFP.Location = new System.Drawing.Point(614, 101);
            this.btnNuevoFP.Name = "btnNuevoFP";
            this.btnNuevoFP.Size = new System.Drawing.Size(100, 50);
            this.btnNuevoFP.TabIndex = 39;
            this.btnNuevoFP.Text = "Nuevo";
            this.btnNuevoFP.UseVisualStyleBackColor = true;
            this.btnNuevoFP.Click += new System.EventHandler(this.btnNuevoFP_Click);
            // 
            // groupForma
            // 
            this.groupForma.Controls.Add(this.txtTipoFP);
            this.groupForma.Controls.Add(this.cbxEstadoFP);
            this.groupForma.Controls.Add(this.btnCancelarFP);
            this.groupForma.Controls.Add(this.btnInsertarFP);
            this.groupForma.Controls.Add(this.lbIDFP);
            this.groupForma.Controls.Add(this.label3);
            this.groupForma.Controls.Add(this.label1);
            this.groupForma.Location = new System.Drawing.Point(63, 341);
            this.groupForma.Name = "groupForma";
            this.groupForma.Size = new System.Drawing.Size(506, 150);
            this.groupForma.TabIndex = 38;
            this.groupForma.TabStop = false;
            this.groupForma.Text = "Datos de Forma de Pago";
            // 
            // cbxEstadoFP
            // 
            this.cbxEstadoFP.AutoSize = true;
            this.cbxEstadoFP.Location = new System.Drawing.Point(235, 29);
            this.cbxEstadoFP.Name = "cbxEstadoFP";
            this.cbxEstadoFP.Size = new System.Drawing.Size(62, 17);
            this.cbxEstadoFP.TabIndex = 30;
            this.cbxEstadoFP.Text = "Estado ";
            this.cbxEstadoFP.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFP
            // 
            this.btnCancelarFP.Location = new System.Drawing.Point(392, 91);
            this.btnCancelarFP.Name = "btnCancelarFP";
            this.btnCancelarFP.Size = new System.Drawing.Size(93, 35);
            this.btnCancelarFP.TabIndex = 29;
            this.btnCancelarFP.Text = "Cancelar";
            this.btnCancelarFP.UseVisualStyleBackColor = true;
            this.btnCancelarFP.Click += new System.EventHandler(this.btnCancelarFP_Click);
            // 
            // btnInsertarFP
            // 
            this.btnInsertarFP.Location = new System.Drawing.Point(392, 29);
            this.btnInsertarFP.Name = "btnInsertarFP";
            this.btnInsertarFP.Size = new System.Drawing.Size(93, 35);
            this.btnInsertarFP.TabIndex = 13;
            this.btnInsertarFP.Text = "Insertar";
            this.btnInsertarFP.UseVisualStyleBackColor = true;
            this.btnInsertarFP.Click += new System.EventHandler(this.btnInsertarFP_Click);
            // 
            // lbIDFP
            // 
            this.lbIDFP.AutoSize = true;
            this.lbIDFP.Location = new System.Drawing.Point(58, 26);
            this.lbIDFP.Name = "lbIDFP";
            this.lbIDFP.Size = new System.Drawing.Size(19, 13);
            this.lbIDFP.TabIndex = 3;
            this.lbIDFP.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvFormaPago
            // 
            this.dgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPago.Location = new System.Drawing.Point(63, 101);
            this.dgvFormaPago.Name = "dgvFormaPago";
            this.dgvFormaPago.ReadOnly = true;
            this.dgvFormaPago.Size = new System.Drawing.Size(506, 207);
            this.dgvFormaPago.TabIndex = 37;
            this.dgvFormaPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormaPago_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 80);
            this.panel1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(253, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "FORMA DE PAGO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTipoFP
            // 
            this.txtTipoFP.Location = new System.Drawing.Point(61, 65);
            this.txtTipoFP.Name = "txtTipoFP";
            this.txtTipoFP.Size = new System.Drawing.Size(236, 20);
            this.txtTipoFP.TabIndex = 31;
            // 
            // CRUD_Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 554);
            this.Controls.Add(this.btnRegresarFP);
            this.Controls.Add(this.btnInhabilitarFP);
            this.Controls.Add(this.btnHabilitarFP);
            this.Controls.Add(this.btnNuevoFP);
            this.Controls.Add(this.groupForma);
            this.Controls.Add(this.dgvFormaPago);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Forma_Pago";
            this.Text = "CRUD_Forma_Pago";
            this.Load += new System.EventHandler(this.CRUD_Forma_Pago_Load);
            this.groupForma.ResumeLayout(false);
            this.groupForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarFP;
        private System.Windows.Forms.Button btnInhabilitarFP;
        private System.Windows.Forms.Button btnHabilitarFP;
        private System.Windows.Forms.Button btnNuevoFP;
        private System.Windows.Forms.GroupBox groupForma;
        private System.Windows.Forms.CheckBox cbxEstadoFP;
        private System.Windows.Forms.Button btnCancelarFP;
        private System.Windows.Forms.Button btnInsertarFP;
        private System.Windows.Forms.Label lbIDFP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFormaPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoFP;
    }
}