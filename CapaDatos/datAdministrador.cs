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
    public class datAdministrador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAdministrador _instancia = new datAdministrador();
        //privado para evitar la instanciación directa
        public static datAdministrador Instancia
        {
            get
            {
                return datAdministrador._instancia;
            }
        }
        #endregion singleton

        #region ADMINISTRADOR

        //ListadoAdministrador
        public List<entAdministrador> ListarAdministrador()
        {
            SqlCommand cmd = null;
            List<entAdministrador> lista = new List<entAdministrador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAdministrador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAdministrador Admin = new entAdministrador();
                    Admin.AdministradorID = Convert.ToInt32(dr["AdministradorID"]);
                    Admin.Usuario = dr["Usuario"].ToString();
                    Admin.Contraseña = dr["Contraseña"].ToString();
                    Admin.estAdministrador = Convert.ToBoolean(dr["estAdministrador"]);
                    lista.Add(Admin);
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
        public Boolean InsertarAdministrador(entAdministrador Admin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAdministrador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Admin.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Admin.Contraseña);
                cmd.Parameters.AddWithValue("@estAdministrador", Admin.estAdministrador);
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

        //HabilitarAdministrador
        public Boolean HabilitarAdministrador(entAdministrador Admin)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarAdministrador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdministradorID", Admin.AdministradorID);
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

        //InhabilitarAdministrador
        public Boolean DeshabilitarAdministrador(entAdministrador Admin)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarAdministrador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdministradorID", Admin.AdministradorID);
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
        //ModificarCliente
        public Boolean ModificarAdministrador(entAdministrador Admin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarAdministrador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdministradorID", Admin.AdministradorID);
                cmd.Parameters.AddWithValue("@Usuario", Admin.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Admin.Contraseña);
                cmd.Parameters.AddWithValue("@estAdministrador", Admin.estAdministrador);
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
        public Boolean ExisteUsuarioAdministrador(string Usuario)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteUsuarioAdministrador", cn);
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
        #endregion ADMINISTRADOR

    }
}
