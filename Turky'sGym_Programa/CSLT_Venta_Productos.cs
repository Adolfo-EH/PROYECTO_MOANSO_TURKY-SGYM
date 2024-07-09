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
    public partial class CSLT_Venta_Productos : Form
    {
        public CSLT_Venta_Productos()
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
        private void CSLT_Venta_Productos_Load(object sender, EventArgs e)
        {
            MostrarUsuarioLogueado();
        }
    }
}
