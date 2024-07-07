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
    public partial class CSLT_Venta_Membresía : Form
    {
        public CSLT_Venta_Membresía()
        {
            InitializeComponent();
        }

        private void btnBuscarVentaServicio_Click(object sender, EventArgs e)
        {
            string searchTerm = txbDNI_Consulta.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {

                foreach (DataGridViewRow row in dgvConsultaPlanes.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                        {
                            // Resaltar la fila si se encuentra el término de búsqueda
                            row.Selected = true;

                            dgvConsultaPlanes.FirstDisplayedScrollingRowIndex = row.Index;

                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
