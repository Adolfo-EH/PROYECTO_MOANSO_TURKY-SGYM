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
        private Dictionary<string, string> precios;
        public CORE_VENTA_MEMBRESÍA()
        {
            InitializeComponent();
            InicializarPrecios();
            cbxTipoPlan.SelectedIndexChanged += new EventHandler(cbxTipoPlan_SelectedIndexChanged);
        }

        private void InicializarPrecios()
        {
            precios = new Dictionary<string, string>
        {
            { "DIARIO", "S/. 8.00" },
            { "MENSUAL", "S/. 80.00" },
            { "TRIMESTRAL", "S/. 180.00" },
            { "SEMESTRAL", "S/. 300.00" },
            { "ANUAL", "S/. 480.00" }
        };

            cbxTipoPlan.Items.AddRange(new object[]
            {
            "DIARIO", "MENSUAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL"
            });
        }

        private void CORE_VENTA_MEMBRESÍA_Load(object sender, EventArgs e)
        {

        }

        private void cbxTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPlan.SelectedItem != null)
            {
                string seleccion = cbxTipoPlan.SelectedItem.ToString();
                if (precios.ContainsKey(seleccion))
                {
                    lblPrecio.Text = precios[seleccion];
                }
            }
        }
    }
}
