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
    public class datRelFichaM
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
        public List<entRelFichaM> ListarFichaM()
        {
            SqlCommand cmd = null;
            List<entRelFichaM> lista = new List<entRelFichaM>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarFichaM", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRelFichaM fm = new entRelFichaM();
                    fm.FichamonitoreoID = Convert.ToInt32(dr["FichamonitoreoID"]);
                    fm.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    fm.GeneroID = Convert.ToInt32(dr["GeneroID"]);
                    fm.ObjetivoPer = dr["ObjetivoPer"].ToString();
                    fm.FechaEva = Convert.ToDateTime(dr["FechaEva"]);
                    fm.ProxCita = Convert.ToDateTime(dr["ProxCita"]);
                    fm.Edad = Convert.ToInt32(dr["Edad"]);
                    fm.Talla = Convert.ToDecimal(dr["Talla"]);
                    fm.IMC = Convert.ToDecimal(dr["IMC"]);
                    fm.Grasa = Convert.ToDecimal(dr["Grasa"]);
                    fm.Hidratacion = Convert.ToDecimal(dr["Hidratacion"]);
                    fm.Peso = Convert.ToDecimal(dr["Peso"]);
                    fm.M_muscular = Convert.ToDecimal(dr["M_muscular"]);
                    fm.M_osea = Convert.ToDecimal(dr["M_osea"]);
                    fm.K_cal = Convert.ToDecimal(dr["K_cal"]);
                    fm.Brazos = Convert.ToDecimal(dr["Brazos"]);
                    fm.Pecho = Convert.ToDecimal(dr["Pecho"]);
                    fm.Cintura = Convert.ToDecimal(dr["Cintura"]);
                    fm.Cadera = Convert.ToDecimal(dr["Cadera"]);
                    fm.Cuadriceps = Convert.ToDecimal(dr["Cuadriceps"]);
                    fm.Pantorrilla = Convert.ToDecimal(dr["Pantorrilla"]);
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

        public List<entRelFichaM> ListarFichaMPorCliente(int? clienteID)
        {
            SqlCommand cmd = null;
            List<entRelFichaM> lista = new List<entRelFichaM>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarFichaM", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", (object)clienteID ?? DBNull.Value);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRelFichaM fm = new entRelFichaM();
                    fm.FichamonitoreoID = Convert.ToInt32(dr["FichamonitoreoID"]);
                    fm.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    fm.GeneroID = Convert.ToInt32(dr["GeneroID"]);
                    fm.ObjetivoPer = dr["ObjetivoPer"].ToString();
                    fm.FechaEva = Convert.ToDateTime(dr["FechaEva"]);
                    fm.ProxCita = Convert.ToDateTime(dr["ProxCita"]);
                    fm.Edad = Convert.ToInt32(dr["Edad"]);
                    fm.Talla = Convert.ToDecimal(dr["Talla"]);
                    fm.IMC = Convert.ToDecimal(dr["IMC"]);
                    fm.Grasa = Convert.ToDecimal(dr["Grasa"]);
                    fm.Hidratacion = Convert.ToDecimal(dr["Hidratacion"]);
                    fm.Peso = Convert.ToDecimal(dr["Peso"]);
                    fm.M_muscular = Convert.ToDecimal(dr["M_muscular"]);
                    fm.M_osea = Convert.ToDecimal(dr["M_osea"]);
                    fm.K_cal = Convert.ToDecimal(dr["K_cal"]);
                    fm.Brazos = Convert.ToDecimal(dr["Brazos"]);
                    fm.Pecho = Convert.ToDecimal(dr["Pecho"]);
                    fm.Cintura = Convert.ToDecimal(dr["Cintura"]);
                    fm.Cadera = Convert.ToDecimal(dr["Cadera"]);
                    fm.Cuadriceps = Convert.ToDecimal(dr["Cuadriceps"]);
                    fm.Pantorrilla = Convert.ToDecimal(dr["Pantorrilla"]);
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
        public Boolean InsertarFichaM(entRelFichaM fm)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFichaM", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", fm.ClienteID);
                cmd.Parameters.AddWithValue("@UsuarioID", fm.UsuarioID);
                cmd.Parameters.AddWithValue("@GeneroID", fm.GeneroID);
                cmd.Parameters.AddWithValue("@ObjetivoPer", fm.ObjetivoPer);
                cmd.Parameters.AddWithValue("@FechaEva", fm.FechaEva);
                cmd.Parameters.AddWithValue("@ProxCita", fm.ProxCita);
                cmd.Parameters.AddWithValue("@Edad", fm.Edad);
                cmd.Parameters.AddWithValue("@Talla", fm.Talla);
                cmd.Parameters.AddWithValue("@IMC", fm.IMC);
                cmd.Parameters.AddWithValue("@Grasa", fm.Grasa);
                cmd.Parameters.AddWithValue("@Hidratacion", fm.Hidratacion);
                cmd.Parameters.AddWithValue("@Peso", fm.Peso);
                cmd.Parameters.AddWithValue("@M_Muscular", fm.M_muscular);
                cmd.Parameters.AddWithValue("@M_Osea", fm.M_osea);
                cmd.Parameters.AddWithValue("@K_Cal", fm.K_cal);
                cmd.Parameters.AddWithValue("@Brazos", fm.Brazos);
                cmd.Parameters.AddWithValue("@Pecho", fm.Pecho);
                cmd.Parameters.AddWithValue("@Cintura", fm.Cintura);
                cmd.Parameters.AddWithValue("@Cadera", fm.Cadera);
                cmd.Parameters.AddWithValue("@Cuadriceps", fm.Cuadriceps);
                cmd.Parameters.AddWithValue("@Pantorrilla", fm.Pantorrilla);
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

        public Boolean EliminarFichaM(int FichamonitoreoID)
        {
            SqlCommand cmd = null;
            Boolean eliminado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarFichaMonitoreo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FichamonitoreoID", FichamonitoreoID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return eliminado;
        }
        public DataTable CargarGenero()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarGenero", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion FICHA MONITOREO

    }
}
