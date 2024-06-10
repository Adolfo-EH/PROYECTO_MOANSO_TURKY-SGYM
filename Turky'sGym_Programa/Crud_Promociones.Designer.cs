namespace Turky_sGym_Programa
{
    partial class Crud_Promociones
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPromociones = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipoPromocion = new System.Windows.Forms.Label();
            this.lblIdPromocion = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPromociones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(694, 394);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 51);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 228);
            this.dataGridView1.TabIndex = 7;
            // 
            // gbPromociones
            // 
            this.gbPromociones.Controls.Add(this.dateTimePicker1);
            this.gbPromociones.Controls.Add(this.label1);
            this.gbPromociones.Controls.Add(this.btnCancelar);
            this.gbPromociones.Controls.Add(this.btnGuardar);
            this.gbPromociones.Controls.Add(this.textBox2);
            this.gbPromociones.Controls.Add(this.lblNombre);
            this.gbPromociones.Controls.Add(this.textBox1);
            this.gbPromociones.Controls.Add(this.lblDescuento);
            this.gbPromociones.Controls.Add(this.label3);
            this.gbPromociones.Controls.Add(this.comboBox1);
            this.gbPromociones.Controls.Add(this.lblTipoPromocion);
            this.gbPromociones.Controls.Add(this.lblIdPromocion);
            this.gbPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromociones.Location = new System.Drawing.Point(122, 363);
            this.gbPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.gbPromociones.Name = "gbPromociones";
            this.gbPromociones.Padding = new System.Windows.Forms.Padding(2);
            this.gbPromociones.Size = new System.Drawing.Size(509, 212);
            this.gbPromociones.TabIndex = 11;
            this.gbPromociones.TabStop = false;
            this.gbPromociones.Text = "Promociones(Productos/Servicios)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duración";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 111);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(407, 54);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 102);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(54, 138);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(72, 16);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "00";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Servicios",
            "Productos"});
            this.comboBox1.Location = new System.Drawing.Point(140, 59);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lblTipoPromocion
            // 
            this.lblTipoPromocion.AutoSize = true;
            this.lblTipoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPromocion.Location = new System.Drawing.Point(4, 62);
            this.lblTipoPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPromocion.Name = "lblTipoPromocion";
            this.lblTipoPromocion.Size = new System.Drawing.Size(122, 16);
            this.lblTipoPromocion.TabIndex = 1;
            this.lblTipoPromocion.Text = "Tipo de Promoción";
            // 
            // lblIdPromocion
            // 
            this.lblIdPromocion.AutoSize = true;
            this.lblIdPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPromocion.Location = new System.Drawing.Point(43, 29);
            this.lblIdPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPromocion.Name = "lblIdPromocion";
            this.lblIdPromocion.Size = new System.Drawing.Size(83, 16);
            this.lblIdPromocion.TabIndex = 0;
            this.lblIdPromocion.Text = "IdPromoción";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(694, 284);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnInhabilitar.TabIndex = 10;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(694, 195);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 51);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(694, 98);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 51);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 74);
            this.panel1.TabIndex = 16;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Titulo.Location = new System.Drawing.Point(348, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(232, 31);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "PROMOCIONES";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Crud_Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbPromociones);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Crud_Promociones";
            this.Text = "Crud_Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPromociones.ResumeLayout(false);
            this.gbPromociones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPromociones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipoPromocion;
        private System.Windows.Forms.Label lblIdPromocion;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
    }
}