using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int UsuarioID { get; set; }
        public int TipoUsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Boolean estUsuario { get; set; }

    }
}
