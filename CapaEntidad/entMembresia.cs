using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMembresia
    {
        public int idMembresia { get; set; }
        public string nombreMemb { get; set; }
        public string nombreServicio { get; set; } 
        public Double precio { get; set; }
        public DateTime duracion { get; set; }
        public Boolean estMembresia{ get; set; }
    }
}
