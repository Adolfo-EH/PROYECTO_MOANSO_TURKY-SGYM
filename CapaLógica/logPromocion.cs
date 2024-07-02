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
    public class logPromocion
    {
        #region singleton
        private static readonly logPromocion _instancia = new logPromocion();
        //privado para evitar la instanciación directa
        public static logPromocion Instancia
        {
            get
            {
                return logPromocion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entPromocion> ListarPromocion()
        {
            return datPromocion.Instancia.ListarPromocion();
        }
        ///inserta
        public void InsertaPromocion(entPromocion pr)
        {
            datPromocion.Instancia.InsertarPromocion(pr);
        }
        //edita
        public void EditaPromocion(entPromocion pr)
        {
            datPromocion.Instancia.EditarPromocion(pr);
        }
        public void DeshabilitarPromocion(entPromocion pr)
        {
            datPromocion.Instancia.DeshabilitarPromocion(pr);
        }
        public void HabilitarPromocion(entPromocion pr)
        {
            datPromocion.Instancia.HabilitarPromocion(pr);
        }

        public DataTable CargarTipoPromocion()
        {
            return datPromocion.Instancia.CargarTipoPromocion();
        }
        #endregion metodos
    }
}
