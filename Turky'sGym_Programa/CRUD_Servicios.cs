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
    public partial class CRUD_Servicios : Form
    {
        public CRUD_Servicios()
        {
            InitializeComponent();
            gbServicio.Enabled = false;
        }

        private void lblVentaServicios_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Servicios_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearS_Click(object sender, EventArgs e)
        {
            gbServicio.Enabled = true;
        }
    }
}
