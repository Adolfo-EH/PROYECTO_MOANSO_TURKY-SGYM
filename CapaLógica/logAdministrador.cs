using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logAdminisrador
    {
        #region singleton
        private static readonly logAdminisrador _instancia = new logAdminisrador();
        //privado para evitar la instanciación directa
        public static logAdminisrador Instancia
        {
            get
            {
                return logAdminisrador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entAdministrador> ListarAdministrador()
        {
            return datAdministrador.Instancia.ListarAdministrador();
        }

        ///inserta
        public void InsertarAdministrador(entAdministrador Admin)
        {
            datAdministrador.Instancia.InsertarAdministrador(Admin);
        }

        ///habilitar
        public void HabilitarAdministrador(entAdministrador Admin)
        {
            datAdministrador.Instancia.HabilitarAdministrador(Admin);
        }

        ///deshabilitar
        public void DeshabilitarAdministrador(entAdministrador Admin)
        {
            datAdministrador.Instancia.DeshabilitarAdministrador(Admin);
        }

        //modificar
        public void ModificarAdministrador(entAdministrador Admin)
        {
            datAdministrador.Instancia.ModificarAdministrador(Admin);
        }
        //condicion
        public Boolean ExisteUsuarioAdministrador(string Usuario)
        {
            return datAdministrador.Instancia.ExisteUsuarioAdministrador(Usuario);
        }
        #endregion metodos
    }
}
