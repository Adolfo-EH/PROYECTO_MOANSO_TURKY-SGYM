using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logCategoria
    {
        #region singleton
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategorias();
        }

        ///inserta
        public void InsertaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.InsertarCategoria(Cat);
        }

        ///habilitar
        public void HabilitarCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.HabilitarCategoria(Cat);
        }

        ///deshabilitar
        public void DeshabilitarCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.DeshabilitarCategoria(Cat);
        }
        #endregion metodos
    }
}
