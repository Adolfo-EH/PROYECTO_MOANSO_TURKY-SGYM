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

        #region MEMBRESIA

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
                    pl.nombreMemb = dr["NombreMemb"].ToString();
                    pl.nombreServicio = dr["Nombre"].ToString();
                    pl.precio = Convert.ToDouble(dr["Precio"]);
                    pl.duracion = Convert.ToDateTime(dr["Duracion"]);
                    pl.estMembresia = Convert.ToBoolean(dr["estPlan"]);
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
        public Boolean InsertarMembresia(entMembresia pl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanID", pl.idMembresia);
                cmd.Parameters.AddWithValue("@Precio", pl.precio);
                cmd.Parameters.AddWithValue("@Duracion", pl.duracion);
                cmd.Parameters.AddWithValue("@estPlan", pl.estMembresia);
                cmd.Parameters.AddWithValue("@NombrePlan", pl.nombreMemb);
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
                cmd = new SqlCommand("spHabilitarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlan", pl.idMembresia);
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
                cmd = new SqlCommand("spDeshabilitarPLan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlan", pl.idMembresia);
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
        #endregion MEMBRESIA
    }
}
