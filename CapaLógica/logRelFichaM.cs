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
    public class logRelFichaM
    {
        #region singleton
        private static readonly logRelFichaM _instancia = new logRelFichaM();
        public static logRelFichaM Instancia
        {
            get { return logRelFichaM._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entRelFichaM> ListarFichaM()
        {
            try
            {
                return datRelFichaM.Instancia.ListarFichaM();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarFichaM(entRelFichaM fm)
        {
            datRelFichaM.Instancia.InsertarFichaM(fm);

        }
        public List<entRelFichaM> ListarFichaMPorCliente(int? ClienteID)
        {
            return datRelFichaM.Instancia.ListarFichaMPorCliente(ClienteID);
        }

        public void EliminarFichaM(int FichamonitoreoID)
        {
            datRelFichaM.Instancia.EliminarFichaM(FichamonitoreoID);
        }


        ///cargar
        public DataTable CargarGenero()
        {
            return datRelFichaM.Instancia.CargarGenero();
        }

        #endregion metodos
    }
}
