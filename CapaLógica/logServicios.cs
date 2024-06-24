using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logServicios
    {
        #region singleton
        private static readonly logServicios _instancia = new logServicios();
        //privado para evitar la instanciación directa
        public static logServicios Instancia
        {
            get
            {
                return logServicios._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entServicios> ListarServicio()
        {
            return datServicios.Instancia.ListarServicios();
        }

        ///inserta
        public void InsertaServicio(entServicios sv)
        {
            datServicios.Instancia.InsertaServicio(sv);
        }

        ///habilitar
        public void HabilitarServicio(entServicios sv)
        {
            datServicios.Instancia.HabilitarServicio(sv);
        }

        ///deshabilitar
        public void DeshabilitarServicio(entServicios sv)
        {
            datServicios.Instancia.DeshabilitarServicio(sv);
        }
        #endregion metodos
    }
}
