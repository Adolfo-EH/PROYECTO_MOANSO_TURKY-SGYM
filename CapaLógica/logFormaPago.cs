using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logFormaPago
    {
        #region singleton
        private static readonly logFormaPago _instancia = new logFormaPago();
        //privado para evitar la instanciación directa
        public static logFormaPago Instancia
        {
            get
            {
                return logFormaPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entFormaPago> ListarFormaPago()
        {
            return datFormaPago.Instancia.ListarFormaPago();
        }
        ///inserta
        public void InsertarFormaPago(entFormaPago fp)
        {
            datFormaPago.Instancia.InsertarFormaPago(fp);
        }
        public void HabilitarFormaPago(entFormaPago fp)
        {
            datFormaPago.Instancia.HabilitarFormaPago(fp);
        }

        public void DeshabilitarFormaPago(entFormaPago fp)
        {
            datFormaPago.Instancia.DeshabilitarFormaPago(fp);
        }
        #endregion metodos
    }
}
