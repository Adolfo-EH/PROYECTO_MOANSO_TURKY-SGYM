using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logVentaProd
    {
        #region singleton
        private static readonly logVentaProd _instancia = new logVentaProd();
        public static logVentaProd Instancia
        {
            get { return logVentaProd._instancia; }
        }
        #endregion singleton

        #region metodos
        /*public List<entVentaProd> ListarVentaProd()
        {
            try
            {
                return datVentaProd.Instancia.ListarVentaProd();
            }
            catch (Exception e)
            {
                throw e;
            }
        }*/
        public int InsertarVentaProd(entVentaProd Prod)
        {
            int a;
            try
            {
                a = datVentaProd.Instancia.InsertarVentaProd(Prod);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetVentaProd(entDetVentaProd dProd)
        {
            try
            {
                datVentaProd.Instancia.InsertarDetVentaProd(dProd);
            }
            catch (Exception e)
            { throw e; }
        }

        #endregion metodos
    }
}
