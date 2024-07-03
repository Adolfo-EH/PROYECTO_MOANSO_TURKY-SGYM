using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logMembresia
    {
        #region singleton
        private static readonly logMembresia _instancia = new logMembresia();
        //privado para evitar la instanciación directa
        public static logMembresia Instancia
        {
            get
            {
                return logMembresia._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entMembresia> ListarMembresia()
        {
            return datMembresia.Instancia.ListarMembresia();
        }
        ///inserta
        public void InsertaMembresia(entMembresia pl)
        {
            datMembresia.Instancia.InsertarMembresia(pl);
        }
        //edita
        public void HabilitarMembresia(entMembresia pl)
        {
            datMembresia.Instancia.HabilitarMembresia(pl);
        }

        public void DeshabilitarMembresia(entMembresia pl)
        {
            datMembresia.Instancia.DeshabilitarMembresia(pl);
        }
        #endregion metodos
    }
}
