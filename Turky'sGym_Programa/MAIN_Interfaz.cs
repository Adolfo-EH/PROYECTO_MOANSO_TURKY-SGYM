using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turky_sGym_Programa
{
    public partial class MAIN_Interfaz : Form
    {
        private Form activeForm;
        private int tipoUsuarioID;

        public MAIN_Interfaz(int tipoUsuarioID)
        {
            InitializeComponent();
            this.tipoUsuarioID = tipoUsuarioID;
            VerificarAccesoAdmin();
            OpenChildForm(new CRUD_Clientes());
        }

        private void VerificarAccesoAdmin()
        {
            if (tipoUsuarioID != 1)
            {
                btnCatPro.Enabled = false;
                btnMarca.Enabled = false;
                btnProd.Enabled = false;
                btnMem.Enabled = false;
                btnServicios.Enabled = false;
                btnMetPago.Enabled = false;
                btnFormPag.Enabled = false;
                btnPromo.Enabled = false;
                btnAdmin.Enabled = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }                       
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPantalla.Controls.Add(childForm);
            this.panelPantalla.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panelPantalla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            LOGIN loginForm = new LOGIN();
            loginForm.Show();
            this.Hide();
        }

        private void btnVentPro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CORE_VENTA_PRODUCTOS());
        }

        private void btnVentMem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CORE_VENTA_MEMBRESÍA());
        }

        private void btnMonCli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CORE_MONITOREO_CLIENTES());
        }

        private void btnCatPro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Categoría());
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Marca());
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Productos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Clientes());
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Membresía());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Servicios());
        }

        private void btnMetPago_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Metodo_Pago());
        }

        private void btnFormPag_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Forma_Pago());
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CRUD_Promocion());
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (tipoUsuarioID == 1)
            {
                OpenChildForm(new CRUD_Usuario());
            }
            else
            {
                MessageBox.Show("No tiene el nivel de acceso necesario para acceder a esta función.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
