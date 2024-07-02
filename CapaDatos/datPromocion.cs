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
    public class datPromocion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPromocion _instancia = new datPromocion();
        //privado para evitar la instanciación directa
        public static datPromocion Instancia
        {
            get
            {
                return datPromocion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entPromocion> ListarPromocion()
        {
            SqlCommand cmd = null;
            List<entPromocion> lista = new List<entPromocion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarPromocion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPromocion pr = new entPromocion();
                    pr.idPromocion = Convert.ToInt32(dr["PromocionID"]);
                    pr.idTipodePromocion = Convert.ToInt32(dr["TipopromocionID"]);
                    pr.nombre = dr["NomPromocion"].ToString();
                    pr.descuento = Convert.ToDouble(dr["Descuento"]);
                    pr.duracion = Convert.ToDateTime(dr["DuracionProm"]);
                    pr.estPromocion = Convert.ToBoolean(dr["estPromocion"]);
                    lista.Add(pr);
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

        public Boolean InsertarPromocion(entPromocion pr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPromocion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipopromocionID", pr.idTipodePromocion);
                cmd.Parameters.AddWithValue("@NomPromocion", pr.nombre);
                cmd.Parameters.AddWithValue("@Descuento", pr.descuento);
                cmd.Parameters.AddWithValue("@DuracionProm", pr.duracion);
                cmd.Parameters.AddWithValue("@estPromocion", pr.estPromocion);

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


        //////////////////////////////////EditaCliente
        public Boolean EditarPromocion(entPromocion pr)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPromocion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPromocion", pr.idPromocion);
                cmd.Parameters.AddWithValue("@IDTipodePromocion", pr.idTipodePromocion);
                cmd.Parameters.AddWithValue("@nombre", pr.nombre);
                cmd.Parameters.AddWithValue("@descuento", pr.descuento);
                cmd.Parameters.AddWithValue("@duracion", pr.duracion);
                cmd.Parameters.AddWithValue("@estPromocion", pr.estPromocion);

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

        //deshabilitaCliente
        public Boolean DeshabilitarPromocion(entPromocion pr)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPromocion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PromocionID", pr.idPromocion);
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
        public Boolean HabilitarPromocion(entPromocion pr)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarPromocion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PromocionID", pr.idPromocion);
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

        public DataTable CargarTipoPromocion()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarTipoPromocion", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion metodos
    }
}
