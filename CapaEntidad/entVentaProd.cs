using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVentaProd
    {
        public int idVentaProd { get; set; }
        public int idAdmin { get; set; }
        public int idFormaPago { get; set; }
        public int idMetodoPago { get; set; }
        public Decimal MontoVenta { get; set; }
        public DateTime fechVentaProd { get; set; }
        public Boolean estVentaProd { get; set; }
        public List<entDetVentaProd> DetVentaProd { get; set; }
    }
}
