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
    public class datPlan
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPlan _instancia = new datPlan();
        //privado para evitar la instanciación directa
        public static datPlan Instancia
        {
            get
            {
                return datPlan._instancia;
            }
        }
        #endregion singleton

        #region categoria

        ////////////////////listado
        public List<entPlan> ListarPlan()
        {
            SqlCommand cmd = null;
            List<entPlan> lista = new List<entPlan>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlan pl = new entPlan();
                    pl.idPlan = Convert.ToInt32(dr["PlanID"]);
                    pl.nombrePlan = dr["NombrePlan"].ToString();
                    pl.nombreServicio = dr["Nombre"].ToString();
                    pl.precio = Convert.ToDouble(dr["Precio"]);
                    pl.duracion = Convert.ToDateTime(dr["Duracion"]);
                    pl.estPlan = Convert.ToBoolean(dr["estPlan"]);
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
        public Boolean InsertarPlan(entPlan pl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanID", pl.idPlan);
                cmd.Parameters.AddWithValue("@Precio", pl.precio);
                cmd.Parameters.AddWithValue("@Duracion", pl.duracion);
                cmd.Parameters.AddWithValue("@estPlan", pl.estPlan);
                cmd.Parameters.AddWithValue("@NombrePlan", pl.nombrePlan);
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
        public Boolean HabilitarPlan(entPlan pl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlan", pl.idPlan);
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
        public Boolean DeshabilitarPlan(entPlan pl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPLan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlan", pl.idPlan);
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
        #endregion categoria
    }
}
