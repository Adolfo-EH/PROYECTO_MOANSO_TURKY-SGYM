namespace Turky_sGym_Programa
{
    partial class CRUD_Planes
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
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPlanes = new System.Windows.Forms.GroupBox();
            this.comboplan = new System.Windows.Forms.TextBox();
            this.textduracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.lblTipoPromocion = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPlanes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(940, 219);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnhabilitar.TabIndex = 29;
            this.btnhabilitar.Text = "HABILITAR";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(940, 274);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 51);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan,
            this.precio,
            this.duracion,
            this.servicio,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(58, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 228);
            this.dataGridView1.TabIndex = 23;
            // 
            // plan
            // 
            this.plan.HeaderText = "PLAN";
            this.plan.Name = "plan";
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            // 
            // duracion
            // 
            this.duracion.HeaderText = "DURACION";
            this.duracion.Name = "duracion";
            // 
            // servicio
            // 
            this.servicio.HeaderText = "SERVICIO";
            this.servicio.Name = "servicio";
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            // 
            // gbPlanes
            // 
            this.gbPlanes.Controls.Add(this.checkBox1);
            this.gbPlanes.Controls.Add(this.label5);
            this.gbPlanes.Controls.Add(this.label4);
            this.gbPlanes.Controls.Add(this.button1);
            this.gbPlanes.Controls.Add(this.comboBox1);
            this.gbPlanes.Controls.Add(this.label3);
            this.gbPlanes.Controls.Add(this.comboplan);
            this.gbPlanes.Controls.Add(this.textduracion);
            this.gbPlanes.Controls.Add(this.label1);
            this.gbPlanes.Controls.Add(this.btnCancelar);
            this.gbPlanes.Controls.Add(this.btnGuardar);
            this.gbPlanes.Controls.Add(this.lblNombre);
            this.gbPlanes.Controls.Add(this.textprecio);
            this.gbPlanes.Controls.Add(this.lblTipoPromocion);
            this.gbPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlanes.Location = new System.Drawing.Point(26, 369);
            this.gbPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Name = "gbPlanes";
            this.gbPlanes.Padding = new System.Windows.Forms.Padding(2);
            this.gbPlanes.Size = new System.Drawing.Size(1024, 262);
            this.gbPlanes.TabIndex = 26;
            this.gbPlanes.TabStop = false;
            this.gbPlanes.Text = "Planes";
            // 
            // comboplan
            // 
            this.comboplan.Location = new System.Drawing.Point(140, 89);
            this.comboplan.Name = "comboplan";
            this.comboplan.Size = new System.Drawing.Size(239, 22);
            this.comboplan.TabIndex = 18;
            // 
            // textduracion
            // 
            this.textduracion.Location = new System.Drawing.Point(140, 168);
            this.textduracion.Margin = new System.Windows.Forms.Padding(2);
            this.textduracion.Name = "textduracion";
            this.textduracion.Size = new System.Drawing.Size(239, 22);
            this.textduracion.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duración:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(407, 87);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(77, 129);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Precio:";
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(140, 126);
            this.textprecio.Margin = new System.Windows.Forms.Padding(2);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(239, 22);
            this.textprecio.TabIndex = 5;
            // 
            // lblTipoPromocion
            // 
            this.lblTipoPromocion.AutoSize = true;
            this.lblTipoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPromocion.Location = new System.Drawing.Point(89, 95);
            this.lblTipoPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPromocion.Name = "lblTipoPromocion";
            this.lblTipoPromocion.Size = new System.Drawing.Size(37, 16);
            this.lblTipoPromocion.TabIndex = 1;
            this.lblTipoPromocion.Text = "Plan:";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(940, 164);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(110, 51);
            this.btnInhabilitar.TabIndex = 25;
            this.btnInhabilitar.Text = "INHABILITAR";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(940, 109);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 51);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 68);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(457, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "PLANES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servicios a agregar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(706, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "AGREGAR SERVICIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Estado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CRUD_Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 664);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbPlanes);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "CRUD_Planes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPlanes.ResumeLayout(false);
            this.gbPlanes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox gbPlanes;
        private System.Windows.Forms.TextBox comboplan;
        private System.Windows.Forms.TextBox textduracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.Label lblTipoPromocion;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}