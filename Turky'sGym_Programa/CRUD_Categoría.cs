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
    public partial class CRUD_Categoría : Form
    {
        public CRUD_Categoría()
        {
            InitializeComponent();
            gbCategoría.Enabled = false;
        }

        private void CRUD_Categoría_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            gbCategoría.Enabled = true;
        }
    }
}
