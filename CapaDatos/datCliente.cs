using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region CLIENTE

        ////////////////////listado de Clientes
        public List<entCliente> ListarClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cl = new entCliente();
                    cl.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cl.NomCliente = dr["NomCliente"].ToString();
                    cl.FechaNac = Convert.ToDateTime(dr["FechaNac"]);
                    cl.Telefono = Convert.ToInt32(dr["Telefono"]);
                    cl.estClienteMemb = Convert.ToBoolean(dr["estClienteMemb"]);
                    lista.Add(cl);
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

        /////////////////////////Inserta Cliente
        public Boolean InsertarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cl.ClienteID);
                cmd.Parameters.AddWithValue("@NomCliente", cl.NomCliente);
                cmd.Parameters.AddWithValue("@FechaNac", cl.FechaNac);
                cmd.Parameters.AddWithValue("@Telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@estClienteMemb", cl.estClienteMemb);
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

        ////////////////////Habilita Cliente
        public Boolean HabilitarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cl.ClienteID);
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

        ////////////////////Deshabilita Cliente
        public Boolean DeshabilitarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cl.ClienteID);
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

        ////////////////////Edita Cliente        
        public Boolean EditarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cl.ClienteID);
                cmd.Parameters.AddWithValue("@NomCliente", cl.NomCliente);
                cmd.Parameters.AddWithValue("@FechaNac", cl.FechaNac);
                cmd.Parameters.AddWithValue("@Telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@estClienteMemb", cl.estClienteMemb);
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

        public entCliente BuscarClienteID(int ClienteID)
        {
            SqlCommand cmd = null;
            entCliente cl = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarClienteID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cl = new entCliente
                    {
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        NomCliente = Convert.ToString(dr["NomCliente"])
                    };
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
            return cl;
        }
        #endregion CLIENTE
    }
}
