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
    public class datMarca
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMarca _instancia = new datMarca();
        //privado para evitar la instanciación directa
        public static datMarca Instancia
        {
            get
            {
                return datMarca._instancia;
            }
        }
        #endregion singleton

        #region MARCA

        ////////////////////listado de Marcas
        public List<entMarca> ListarMarcas()
        {
            SqlCommand cmd = null;
            List<entMarca> lista = new List<entMarca>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMarca mr = new entMarca();
                    mr.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    mr.idMarca = Convert.ToInt32(dr["MarcaID"]);
                    mr.nomMarca = dr["NomMarca"].ToString();
                    mr.estMarca = Convert.ToBoolean(dr["estMarca"]);
                    lista.Add(mr);
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

        /////////////////////////Inserta Marcas
        public Boolean InsertarMarca(entMarca mr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", mr.CategoriaID);
                cmd.Parameters.AddWithValue("@nomMarca", mr.nomMarca);
                cmd.Parameters.AddWithValue("@estMarca", mr.estMarca);
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

        ////////////////////Habilita Marca
        public Boolean HabilitarMarca(entMarca mr)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMarca", mr.idMarca);
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

        ////////////////////Deshabilita Marca
        public Boolean DeshabilitarMarca(entMarca mr)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMarca", mr.idMarca);
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
        public DataTable CargarCategoria()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarCategoria", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion MARCA

    }
}
