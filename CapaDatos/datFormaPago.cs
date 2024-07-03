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

        #region FORMA DE PAGO
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
                    entFormaPago fp = new entFormaPago();
                    fp.FormadepagoID = Convert.ToInt32(dr["FormadepagoID"]);
                    fp.NomForma = dr["NomForma"].ToString();
                    fp.estForma = Convert.ToBoolean(dr["estForma"]);
                    lista.Add(fp);
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

        //insertaFormaPago
        public Boolean InsertarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NomForma", fp.NomForma);
                cmd.Parameters.AddWithValue("@estForma", fp.estForma);
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

        //habilitaFormaPago
        public Boolean HabilitarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FormadepagoID", fp.FormadepagoID);
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

        //deshabilitaFormaPago
        public Boolean DeshabilitarFormaPago(entFormaPago fp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FormadepagoID", fp.FormadepagoID);
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

        //ValidacionFormaPago
        public Boolean ExisteFormaPago(string NomForma)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteFormaPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NomForma", NomForma);
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
        #endregion FORMA DE PAGO
    }
}
