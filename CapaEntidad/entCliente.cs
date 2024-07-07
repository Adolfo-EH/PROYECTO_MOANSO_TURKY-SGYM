using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public string NomCliente { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }
        public Boolean estClienteMemb { get; set; }
    }
}
