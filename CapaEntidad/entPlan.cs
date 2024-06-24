using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlan
    {
        public int idPlan { get; set; }
        public string nombrePlan { get; set; }
        public string nombreServicio { get; set; } 
        public Double precio { get; set; }
        public DateTime duracion { get; set; }
        public Boolean estPlan{ get; set; }
    }
}
