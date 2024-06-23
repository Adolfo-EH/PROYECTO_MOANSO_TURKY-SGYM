using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logMarca
    {
        #region singleton
        private static readonly logMarca _instancia = new logMarca();
        //privado para evitar la instanciación directa
        public static logMarca Instancia
        {
            get
            {
                return logMarca._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarcas();
        }

        ///inserta
        public void InsertaMarca(entMarca mr)
        {
            datMarca.Instancia.InsertarMarca(mr);
        }

        ///habilitar
        public void HabilitarMarca(entMarca mr)
        {
            datMarca.Instancia.HabilitarMarca(mr);
        }

        ///deshabilitar
        public void DeshabilitarMarca(entMarca mr)
        {
            datMarca.Instancia.DeshabilitarMarca(mr);
        }
        #endregion metodos
    }
}
