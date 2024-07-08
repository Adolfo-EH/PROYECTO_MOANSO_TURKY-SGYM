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
        public int InsertarVentaMem(entVentaMem Mem)
        {

            SqlCommand cmd = null;
            int idVen = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVentaMem", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AdministradorID", Mem.AdministradorID);
                cmd.Parameters.AddWithValue("@ClienteID", Mem.ClienteID);
                cmd.Parameters.AddWithValue("@FormadepagoID", Mem.FormadepagoID);
                cmd.Parameters.AddWithValue("@MembresiaID", Mem.MembresiaID);
                cmd.Parameters.AddWithValue("@MetododepagoID", Mem.MetododepagoID);
                cmd.Parameters.AddWithValue("@PromocionID", Mem.PromocionID);
                cmd.Parameters.AddWithValue("@FechaVenMemb", Mem.FechaVenMemb);
                cmd.Parameters.AddWithValue("@MontoVenMemb", Mem.MontoVenMemb);
                cmd.Parameters.AddWithValue("@Comentario", Mem.Comentario);

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
    }
}
