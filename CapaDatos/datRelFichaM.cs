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
    internal class datRelFichaM
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datRelFichaM _instancia = new datRelFichaM();
        //privado para evitar la instanciación directa
        public static datRelFichaM Instancia
        {
            get
            {
                return datRelFichaM._instancia;
            }
        }
        #endregion singleton

        #region FICHA MONITOREO
        public List<entRelFichaM> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entRelFichaM> lista = new List<entRelFichaM>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRelFichaM fm = new entRelFichaM();
                    fm.FichamonitoreoID = Convert.ToInt32(dr["FichamonitoreoID"]);
                    fm.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    fm.ObjetivoPer = dr["ObjetivoPer"].ToString();
                    fm.FechaEva = Convert.ToDateTime(dr["FechaEva"]);
                    fm.ProxCita = Convert.ToDateTime(dr["ProxCita"]);
                    fm.Edad = Convert.ToInt32(dr["Edad"]);
                    fm.Talla = Convert.ToDecimal(dr["Talla"]);
                    fm.IMC = Convert.ToDecimal(dr["Talla"]);
                    fm.P_Grasa = Convert.ToDecimal(dr["Talla"]);
                    fm.Hidratacion = Convert.ToDecimal(dr["Talla"]);
                    fm.Peso = Convert.ToDecimal(dr["Talla"]);
                    fm.M_Muscular = Convert.ToDecimal(dr["Talla"]);
                    fm.M_Osea = Convert.ToDecimal(dr["Talla"]);
                    fm.K_Cal = Convert.ToDecimal(dr["Talla"]);
                    fm.Brazos = Convert.ToDecimal(dr["Talla"]);
                    fm.Pecho = Convert.ToDecimal(dr["Talla"]);
                    fm.Cintura = Convert.ToDecimal(dr["Talla"]);
                    fm.Cadera = Convert.ToDecimal(dr["Talla"]);
                    fm.Cuadriceps = Convert.ToDecimal(dr["Talla"]);
                    fm.Pantorrilla = Convert.ToDecimal(dr["Talla"]);
                    fm.estFichaMonitoreo = Convert.ToBoolean(dr["estFichaMonitoreo"]);
                    lista.Add(fm);
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
                cmd.Parameters.AddWithValue("@NomMetodo", mp.nombre);
                cmd.Parameters.AddWithValue("@TipometodopagoID", mp.TipometodopagoID);
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

        public DataTable CargarTipoMetodo()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarTipoMetodo", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarMetodoPago(int idTipo)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarMetodoPago", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TipoMetodoPagoID", idTipo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion FICHA MONITOREO
    }
}
