using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVentaMem
    {
        public int VentaMembresiaID { get; set; }
        public int UsuarioID { get; set; }
        public int ClienteID { get; set; }
        public int FormadepagoID { get; set; }
        public int MembresiaID { get; set; }
        public int MetododepagoID { get; set; }
        public int PromocionID { get; set; }
        public DateTime FechaVenMemb { get; set; }
        public Decimal MontoVenMemb { get; set; }
        public string Comentario { get; set; }
        public Boolean estVentaMemb { get; set; }
    }
}
