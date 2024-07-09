using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton

        #region USUARIO

        //ListadoUsuario
        public List<entUsuario> ListarUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario user = new entUsuario();
                    user.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                    user.TipoUsuarioID = Convert.ToInt32(dr["TipousuarioID"]);
                    user.Usuario = dr["Usuario"].ToString();
                    user.Contraseña = dr["Clave"].ToString();
                    user.estUsuario = Convert.ToBoolean(dr["estUsuario"]);
                    lista.Add(user);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //InsertarAdministrador
        public Boolean InsertarUsuario(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoUsuarioID", User.TipoUsuarioID);
                cmd.Parameters.AddWithValue("@Usuario", User.Usuario);
                cmd.Parameters.AddWithValue("@Clave", User.Contraseña);
                cmd.Parameters.AddWithValue("@estUsuario", User.estUsuario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //HabilitarUsuario
        public Boolean HabilitarUsuario(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", User.UsuarioID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        //InhabilitarUsuario
        public Boolean DeshabilitarUsuario(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", User.UsuarioID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        //ModificarUsuario
        public Boolean ModificarUsuario(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", User.UsuarioID);
                cmd.Parameters.AddWithValue("@TipoUsuarioID", User.TipoUsuarioID);
                cmd.Parameters.AddWithValue("@Usuario", User.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", User.Contraseña);
                cmd.Parameters.AddWithValue("@estUsuario", User.estUsuario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;

        }
        //CondicionExisteUsuario
        public Boolean ExisteUsuario(string Usuario)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return existe;
        }
        //CargarTipoUsuario
        public DataTable CargarTipoUsuario()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarTipoUsuario", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion USUARIO
    }
}
