using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logUsuario
    {
        #region singleton
        private static entUsuario usuarioLogueado;
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entUsuario> ListarUsuario()
        {
            return datUsuario.Instancia.ListarUsuario();
        }

        ///inserta
        public void InsertarUsuario(entUsuario User)
        {
            datUsuario.Instancia.InsertarUsuario(User);
        }

        ///habilitar
        public void HabilitarUsuario(entUsuario User)
        {
            datUsuario.Instancia.HabilitarUsuario(User);
        }

        ///deshabilitar
        public void DeshabilitarUsuario(entUsuario User)
        {
            datUsuario.Instancia.DeshabilitarUsuario(User);
        }

        //modificar
        public void ModificarUsuario(entUsuario User)
        {
            datUsuario.Instancia.ModificarUsuario(User);
        }
        //condicion
        public Boolean ExisteUsuario(string User)
        {
            return datUsuario.Instancia.ExisteUsuario(User);
        }
        public DataTable CargarTipoUsuario()
        {
            return datUsuario.Instancia.CargarTipoUsuario();
        }
        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            try
            {
                bool credencialesValidas = datUsuario.Instancia.ValidarCredenciales(nombreUsuario, contraseña);
                if (credencialesValidas)
                {
                    usuarioLogueado = datUsuario.Instancia.ObtenerUsuarioPorNombre(nombreUsuario);
                }
                return credencialesValidas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public entUsuario ObtenerUsuarioLogueado()
        {
            return usuarioLogueado;
        }
        public int ObtenerTipousuarioIDPorNombre(string nombreUsuario)
        {
            try
            {
                return datUsuario.Instancia.ObtenerTipousuarioIDPorNombre(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion metodos
    }
}
