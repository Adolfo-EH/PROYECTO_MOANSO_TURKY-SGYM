using CapaEntidad;
using CapaLógica;
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
    public partial class CORE_VENTA_MEMBRESÍA : Form
    {
        public CORE_VENTA_MEMBRESÍA()
        {
            InitializeComponent();
        }
        private void MostrarUsuarioLogueado()
        {
            entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioLogueado();
            if (usuario != null)
            {
                lblUsuario.Text = "Usuario: " + usuario.Usuario;
            }
        }
        private void CORE_VENTA_MEMBRESÍA_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
        }

        private void cbxTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            CSLT_Venta_Membresía mainForm = new CSLT_Venta_Membresía();
            mainForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
