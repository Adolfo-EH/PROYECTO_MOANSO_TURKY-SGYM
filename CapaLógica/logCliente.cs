using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCliente> ListarClientes()
        {
            return datCliente.Instancia.ListarClientes();
        }

        ///inserta
        public void InsertarCliente(entCliente cl)
        {
            datCliente.Instancia.InsertarCliente(cl);
        }

        ///habilitar
        public void HabilitarCliente(entCliente cl)
        {
            datCliente.Instancia.HabilitarCliente(cl);
        }

        ///deshabilitar
        public void DeshabilitarCliente(entCliente cl)
        {
            datCliente.Instancia.DeshabilitarCliente(cl);
        }

        ///editar
        public void EditarCliente(entCliente cl)
        {
            datCliente.Instancia.EditarCliente(cl);
        }
        #endregion metodos
    }
}
