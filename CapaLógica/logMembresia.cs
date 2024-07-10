using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int InsertaMembresia(entMembresia pl)
        {
            int a;
            try
            {
                a = datMembresia.Instancia.InsertarMembresia(pl);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertaSerMemb(int idSer, int idMemb)
        {
            datMembresia.Instancia.InsertarSerMemb(idSer, idMemb);
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
        public entMembresia BuscarMembresiaID(int idMembresia)
        {
            try
            {
                return datVentaMem.Instancia.BuscarMembresiaID(idMembresia);
            }
            catch (Exception e) { throw e; }
        }
        public DataTable CargarMembresia()
        {
            return datMembresia.Instancia.CargarMembresia();
        }
        #endregion metodos
    }
}
