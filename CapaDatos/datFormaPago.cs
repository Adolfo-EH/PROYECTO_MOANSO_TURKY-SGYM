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
    public class datFormaPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datFormaPago _instancia = new datFormaPago();
        //privado para evitar la instanciación directa
        public static datFormaPago Instancia
        {
            get
            {
                return datFormaPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entFormaPago> ListarFormaPago()
        {
            SqlCommand cmd = null;
            List<entFormaPago> lista = new List<entFormaPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entFormaPago mp = new entFormaPago();
                    mp.idFormaPago = Convert.ToInt32(dr["FormaPagoID"]);
                    mp.nombreF = dr["nombre"].ToString();
                    mp.estFormaPago = Convert.ToBoolean(dr["estForma"]);
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

        public Boolean InsertarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", fp.nombreF);
                cmd.Parameters.AddWithValue("@estForma", fp.estFormaPago);
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

        public Boolean HabilitarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFormaPago", fp.idFormaPago);
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
        public Boolean DeshabilitarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFormaPago", fp.idFormaPago);
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
