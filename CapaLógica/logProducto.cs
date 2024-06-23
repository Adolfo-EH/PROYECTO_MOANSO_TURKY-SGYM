using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logProducto
    {
        #region singleton
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        ///inserta
        public void InsertaProducto(entProducto pr)
        {
            datProducto.Instancia.InsertarProducto(pr);
        }
        //edita
        public void EditaProducto(entProducto pr)
        {
            datProducto.Instancia.EditarProducto(pr);
        }

        public void DeshabilitarProducto(entProducto pr)
        {
            datProducto.Instancia.DeshabilitarProducto(pr);
        }
        #endregion metodos
    }
}
