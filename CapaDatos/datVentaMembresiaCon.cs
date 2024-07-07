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
    class datVentaMembresiaCon
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datVentaMembresiaCon _instancia = new datVentaMembresiaCon();
        //privado para evitar la instanciación directa
        public static datVentaMembresiaCon Instancia
        {
            get
            {
                return datVentaMembresiaCon._instancia;
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
                cmd = new SqlCommand("spListarBusqueda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMembresia pl = new entMembresia();


                    pl.idMembresia = Convert.ToInt32(dr["VentaMembresiaID"]);
                    pl.idMembresia = Convert.ToInt32(dr["ClienteID"]);
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
                cmd = new SqlCommand("spInsertarConsultaM", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VentaMembresiaID", pl.nombreMeb);
                cmd.Parameters.AddWithValue("@ClienteID", pl.duracion);


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

        public Boolean InsertarSerMemb(int VentaMembresiaID, int ClienteID)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCargarConsulta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VentaMembresiaID", VentaMembresiaID);
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
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

        #endregion singleton
    }
}
