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
    public class datMembresia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMembresia _instancia = new datMembresia();
        //privado para evitar la instanciación directa
        public static datMembresia Instancia
        {
            get
            {
                return datMembresia._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////listado
        public List<entMembresia> ListarMembresia()
        {
            SqlCommand cmd = null;
            List<entMembresia> lista = new List<entMembresia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMembresia pl = new entMembresia();

                    pl.idMembresia = Convert.ToInt32(dr["MembresiaID"]);
                    pl.nombreMeb = dr["NomMembresia"].ToString();
                    pl.nombreSer = dr["NomServicio"].ToString();
                    pl.duracion = dr["DuracionMemb"].ToString();
                    pl.precio = Convert.ToDouble(dr["PrecioMemb"]);
                    pl.estMembresia = Convert.ToBoolean(dr["estMembresia"]);
                    lista.Add(pl);
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

        /////////////////////////Insertar
        public int InsertarMembresia(entMembresia pl)
        {
            SqlCommand cmd = null;
            int idMeb = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NomMembresia", pl.nombreMeb);
                cmd.Parameters.AddWithValue("@DuracionMemb", pl.duracion);
                cmd.Parameters.AddWithValue("@PrecioMemb", pl.precio);
                cmd.Parameters.AddWithValue("@estMembresia", pl.estMembresia);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idMeb = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idMeb;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }

        public Boolean InsertarSerMemb(int idServicio, int idMembresia)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarSerMemb", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServicioID", idServicio);
                cmd.Parameters.AddWithValue("@MembresiaID", idMembresia);
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

        //habilitar
        public Boolean HabilitarMembresia(entMembresia pl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembresiaID", pl.idMembresia);
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

        //deshabilitar
        public Boolean DeshabilitarMembresia(entMembresia pl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembresiaID", pl.idMembresia);
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
        public DataTable CargarMembresia()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarMembresia", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion metodos
    }
}
