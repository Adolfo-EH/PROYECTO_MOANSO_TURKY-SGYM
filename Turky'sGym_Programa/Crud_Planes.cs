using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turky_sGym_Programa
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            gbPlanes.Enabled = false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();


            dataGridView1.Rows[n].Cells[0].Value = comboplan.Text;
            dataGridView1.Rows[n].Cells[1].Value = textprecio.Text;
            dataGridView1.Rows[n].Cells[2].Value = textduracion.Text;
            List<string> checkboxesMarcados = new List<string>();
            if (checkBox1.Checked)
            {
                checkboxesMarcados.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                checkboxesMarcados.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                checkboxesMarcados.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                checkboxesMarcados.Add(checkBox4.Text);
            }
            if (checkBox5.Checked)
            {
                checkboxesMarcados.Add(checkBox5.Text);
            }


            dataGridView1.Rows[n].Cells[3].Value = string.Join(", ", checkboxesMarcados);
            dataGridView1.Rows[n].Cells[4].Value = "habilitado";

            gbPlanes.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comboplan.Text = "";
            textprecio.Text = "";
            textduracion.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbPlanes.Enabled = true;
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Estado"].Value = "Inhabilitado";
            }
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Estado"].Value = "Habilitado";
            }
        }
    }
}
