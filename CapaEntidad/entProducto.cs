using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public Boolean estProducto { get; set; }
    }
}
