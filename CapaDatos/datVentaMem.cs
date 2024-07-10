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
    public class datVentaMem
    {
        #region singleton
        private static readonly datVentaMem _instancia = new datVentaMem();
        public static datVentaMem Instancia
        {
            get { return datVentaMem._instancia; }
        }
        #endregion singleton

        #region metodos
        public int InsertarVentaMem(entVentaMem Mem)
        {

            SqlCommand cmd = null;
            int idVen = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVentaMem", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", Mem.UsuarioID);
                cmd.Parameters.AddWithValue("@ClienteID", Mem.ClienteID);
                cmd.Parameters.AddWithValue("@MetododepagoID", Mem.MetododepagoID);
                cmd.Parameters.AddWithValue("@FormadepagoID", Mem.FormadepagoID);
                cmd.Parameters.AddWithValue("@MembresiaID", Mem.MembresiaID);
                cmd.Parameters.AddWithValue("@PromocionID", Mem.PromocionID);
                cmd.Parameters.AddWithValue("@FechaVenMemb", Mem.FechaVenMemb);
                cmd.Parameters.AddWithValue("@MontoVenMemb", Mem.MontoVenMemb);
                cmd.Parameters.AddWithValue("@Comentario", Mem.Comentario);
                cmd.Parameters.AddWithValue("@estVentaMemb", Mem.estVentaMemb);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idVen = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idVen;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }
        public entMembresia BuscarMembresiaID(int MembresiaID)
        {
            SqlCommand cmd = null;
            entMembresia cl = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaridMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembresiaID", MembresiaID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cl = new entMembresia
                    {
                        idMembresia = Convert.ToInt32(dr["MembresiaID"]),
                        duracion = Convert.ToString(dr["DuracionMemb"]),
                        precio = Convert.ToInt32(dr["PrecioMemb"]),
                    };
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
            return cl;
        }
        #endregion metodos
    }
}
