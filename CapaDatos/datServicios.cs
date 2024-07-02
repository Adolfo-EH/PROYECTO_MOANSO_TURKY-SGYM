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
    public class datServicios
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datServicios _instancia = new datServicios();
        //privado para evitar la instanciación directa
        public static datServicios Instancia
        {
            get
            {
                return datServicios._instancia;
            }
        }
        #endregion singleton

        #region Servicios

        ////////////////////listado de Servicios
        public List<entServicios> ListarServicios()
        {
            SqlCommand cmd = null;
            List<entServicios> lista = new List<entServicios>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entServicios sv = new entServicios();
                    sv.nombreSV = dr["NomServicio"].ToString();
                    sv.idServicio = Convert.ToInt32(dr["ServiciosID"]);
                    sv.estServicio = Convert.ToBoolean(dr["estServicio"]);
                    lista.Add(sv);
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

        /////////////////////////InsertaServicio
        public Boolean InsertaServicio(entServicios sv)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NomServicio", sv.nombreSV);
                cmd.Parameters.AddWithValue("@estServicio", sv.estServicio);
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

        //habilitaServicio
        public Boolean HabilitarServicio(entServicios sv)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServiciosID", sv.idServicio);
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

        //deshabilitaServicio
        public Boolean DeshabilitarServicio(entServicios sv)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServiciosID", sv.idServicio);
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

        #endregion Servicios
    }
}
