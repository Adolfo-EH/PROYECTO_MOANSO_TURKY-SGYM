using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRelFichaM
    {
        public int FichamonitoreoID { get; set; }
        public int ClienteID { get; set; }
        public int AdministradorID { get; set; }
        public string ObjetivoPer { get; set; }
        public DateTime FechaEva { get; set; }
        public DateTime ProxCita { get; set; }
        public int Edad { get; set; }
        public Decimal Talla { get; set; }
        public Decimal IMC { get; set; }
        public Decimal P_Grasa { get; set; }
        public Decimal Hidratacion { get; set; }
        public Decimal Peso { get; set; }
        public Decimal M_Muscular { get; set; }
        public Decimal M_Osea { get; set; }
        public Decimal K_Cal { get; set; }
        public Decimal Brazos { get; set; }
        public Decimal Pecho { get; set; }
        public Decimal Cintura { get; set; }
        public Decimal Cadera { get; set; }
        public Decimal Cuadriceps { get; set; }
        public Decimal Pantorrilla { get; set; }
        public Boolean estFichaMonitoreo { get; set; }
    }
}
