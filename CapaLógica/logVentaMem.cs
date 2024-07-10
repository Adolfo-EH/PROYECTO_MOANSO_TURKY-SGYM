using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logVentaMem
    {
        #region singleton
        private static readonly logVentaMem _instancia = new logVentaMem();
        public static logVentaMem Instancia
        {
            get { return logVentaMem._instancia; }
        }
        #endregion singleton

        #region metodos

        public int InsertarVentaMem(entVentaMem Mem)
        {
            int a;
            try
            {
                a = datVentaMem.Instancia.InsertarVentaMem(Mem);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        #endregion metodos
    }
}
