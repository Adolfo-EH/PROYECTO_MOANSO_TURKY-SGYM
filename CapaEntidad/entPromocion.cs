using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPromocion
    {
        public int idPromocion { get; set; }
        public int idTipodePromocion { get; set; }
        public string nombre { get; set; }
        public double descuento { get; set; }
        public DateTime duracion {  get; set; }
        public Boolean estPromocion { get; set; }
    }
}
