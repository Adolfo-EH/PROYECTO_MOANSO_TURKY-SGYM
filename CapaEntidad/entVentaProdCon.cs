using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVentaProdCon
    {
        public Boolean estVenta { get; set; }
        public DateTime FechaVenProd { get; set; }
        public int DetalleVentaproductoID { get; set; }
        public int VentaproductoID { get; set; }
        public entProducto Producto { get; set; }
        public entCategoria Categoria { get; set; }
        public entMarca Marca { get; set; }
        public entMetodoPago MetodoPago { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
