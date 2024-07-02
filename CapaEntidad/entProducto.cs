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
        public int idMarca { get; set; }
        public string NomPro { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public Boolean estProducto { get; set; }
    }
}
