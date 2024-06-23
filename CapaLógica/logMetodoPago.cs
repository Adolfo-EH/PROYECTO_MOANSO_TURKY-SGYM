using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logMetodoPago
    {
        #region singleton
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        //privado para evitar la instanciación directa
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();
        }
        ///inserta
        public void InsertaMetodoPago(entMetodoPago mp)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(mp);
        }
        public void HabilitarMetodoPago(entMetodoPago mp)
        {
            datMetodoPago.Instancia.HabilitarMetodoPago(mp);
        }

        public void DeshabilitarMetodoPago(entMetodoPago mp)
        {
            datMetodoPago.Instancia.DeshabilitarMetodoPago(mp);
        }
        #endregion metodos
    }
}
