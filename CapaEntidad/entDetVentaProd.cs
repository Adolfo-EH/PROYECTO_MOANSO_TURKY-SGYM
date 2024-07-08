using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetVentaProd
    {
        public int idDetVentaProd { get; set; }
        public int idVentaProd { get; set; }
        public int cantProducto { get; set; }
        public Decimal precUnitario { get; set; }
        public Decimal precDescuento { get; set; }
        public Decimal precTotal { get; set; }
        public entProducto idProducto { get; set; }
        public entPromocion idPromocion { get; set; }
    }
}
