namespace CapaPresentación
{
    partial class formMetodoPago
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.groupMetodo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstadoMetodoPago = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            this.groupMetodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-8, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 80);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(249, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "MÉTODO DE PAGO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodoPago.Location = new System.Drawing.Point(12, 79);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.ReadOnly = true;
            this.dgvMetodoPago.Size = new System.Drawing.Size(506, 207);
            this.dgvMetodoPago.TabIndex = 23;
            this.dgvMetodoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodoPago_CellDoubleClick);
            // 
            // groupMetodo
            // 
            this.groupMetodo.Controls.Add(this.cbxEstadoMetodoPago);
            this.groupMetodo.Controls.Add(this.btnCancelar);
            this.groupMetodo.Controls.Add(this.btnInsertar);
            this.groupMetodo.Controls.Add(this.txtTipo);
            this.groupMetodo.Controls.Add(this.txtNombre);
            this.groupMetodo.Controls.Add(this.lbID);
            this.groupMetodo.Controls.Add(this.label3);
            this.groupMetodo.Controls.Add(this.label2);
            this.groupMetodo.Controls.Add(this.label1);
            this.groupMetodo.Location = new System.Drawing.Point(12, 292);
            this.groupMetodo.Name = "groupMetodo";
            this.groupMetodo.Size = new System.Drawing.Size(506, 155);
            this.groupMetodo.TabIndex = 24;
            this.groupMetodo.TabStop = false;
            this.groupMetodo.Text = "Datos de Método de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(33, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "00";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(43, 114);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(116, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(600, 79);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(600, 149);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnHabilitar.TabIndex = 26;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(600, 215);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitar.TabIndex = 27;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(600, 281);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 50);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(407, 29);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 35);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstadoMetodoPago
            // 
            this.cbxEstadoMetodoPago.AutoSize = true;
            this.cbxEstadoMetodoPago.Location = new System.Drawing.Point(235, 29);
            this.cbxEstadoMetodoPago.Name = "cbxEstadoMetodoPago";
            this.cbxEstadoMetodoPago.Size = new System.Drawing.Size(62, 17);
            this.cbxEstadoMetodoPago.TabIndex = 30;
            this.cbxEstadoMetodoPago.Text = "Estado ";
            this.cbxEstadoMetodoPago.UseVisualStyleBackColor = true;
            // 
            // formMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 459);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupMetodo);
            this.Controls.Add(this.dgvMetodoPago);
            this.Controls.Add(this.panel1);
            this.Name = "formMetodoPago";
            this.Text = "formMetodoPago";
            this.Load += new System.EventHandler(this.formMetodoPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            this.groupMetodo.ResumeLayout(false);
            this.groupMetodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.GroupBox groupMetodo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox cbxEstadoMetodoPago;
    }
}