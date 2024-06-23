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
    public class datMetodoPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instanciación directa
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago mp = new entMetodoPago();
                    mp.idMetodoPago = Convert.ToInt32(dr["MetodoDePagoID"]);
                    mp.nombre = dr["nombre"].ToString();
                    mp.tipo = dr["tipo"].ToString();
                    mp.estMetodoPago = Convert.ToBoolean(dr["estMetodo"]);
                    lista.Add(mp);
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

        public Boolean InsertarMetodoPago(entMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", mp.nombre);
                cmd.Parameters.AddWithValue("@tipo", mp.tipo);
                cmd.Parameters.AddWithValue("@estMetodo", mp.estMetodoPago);
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

        public Boolean HabilitarMetodoPago(entMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMetodoPago", mp.idMetodoPago);
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

        //deshabilitaCliente
        public Boolean DeshabilitarMetodoPago(entMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMetodoPago", mp.idMetodoPago);
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
        #endregion metodos
    }
}
