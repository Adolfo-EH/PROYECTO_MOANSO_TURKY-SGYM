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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }
        CRUD_Categoría form = new CRUD_Categoría();
        private void btnInicio_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (logUsuario.Instancia.ValidarCredenciales(nombreUsuario, contraseña))
            {
                int tipoUsuarioID = logUsuario.Instancia.ObtenerTipousuarioIDPorNombre(nombreUsuario);
                MessageBox.Show("Inicio de sesión exitoso");
                MAIN_Interfaz frm = new MAIN_Interfaz(tipoUsuarioID);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
