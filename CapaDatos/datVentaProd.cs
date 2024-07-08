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
    public class datVentaProd
    {
        #region singleton
        private static readonly datVentaProd _instancia = new datVentaProd();
        public static datVentaProd Instancia
        {
            get { return datVentaProd._instancia; }
        }
        #endregion singleton

        #region metodos
        /*public List<entVentaProd> ListarVentaProd()
        {
            /*SqlCommand cmd = null;
            List<entVentaProd> lista = new List<entVentaProd>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVentaProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entVentaProd Ped = new entVentaProd();
                    //----Ped.idCliente = new entCliente();
                    entCliente Cli = new entCliente();

                    Ped.idPedido = Convert.ToInt32(dr["idPedido"]);
                    Ped.estPedido = Convert.ToBoolean(dr["estPedido"]);
                    Ped.fechPedido = Convert.ToDateTime(dr["fechPedido"]);

                    //----Ped.idCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.RazonSocial = dr["RazonSocial"].ToString();


                    Ped.idCliente = Cli;
                    //Ped.idCliente.idCliente =Cli.idCliente;
                    //Ped.idCliente = (entCliente) Cli.idCliente;
                    //Ped.idCliente.idCliente = (int) Cli.idCliente;
                    //Console.WriteLine("idCliente "+Ped.idCliente.idCliente);



                    //////////pd.idDetPedido= Convert.ToInt16(dr["idDetPedido"]);
                    //////////Ped.idPedido= pd.idPedido;
                    //////////pd.cantProducto = Convert.ToInt16(dr["canProducto"]);
                    //////////pd.precProducto = Convert.ToDecimal(dr["precProducto"]);
                    //pd.Importe = Convert.ToDecimal(dr["Importe"]);
                    //pd.Importe = (Decimal)(dr["Importe"]);
                    Ped.TotPedido = Convert.ToDouble(dr["TotPedido"]);
                    lista.Add(Ped);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }*/
        public int InsertarVentaProd(entVentaProd Prod)
        {

            SqlCommand cmd = null;
            int idVen = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVentaProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AdministradorID", Prod.idAdmin);
                cmd.Parameters.AddWithValue("@FormadepagoID", Prod.idFormaPago);
                cmd.Parameters.AddWithValue("@MetododepagoID", Prod.idMetodoPago);
                cmd.Parameters.AddWithValue("@MontoVenta", Prod.MontoVenta);
                cmd.Parameters.AddWithValue("@FechaVenProd", Prod.fechVentaProd);
                cmd.Parameters.AddWithValue("@estVenta", Prod.estVentaProd);

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
        public Boolean InsertarDetVentaProd(entDetVentaProd dProd)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetVentaProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VentaproductoID", dProd.idVentaProd);
                cmd.Parameters.AddWithValue("@ProductosID", dProd.idProducto.idProducto);
                cmd.Parameters.AddWithValue("@PromocionID", dProd.idPromocion.idPromocion);
                cmd.Parameters.AddWithValue("@Cantidad", dProd.cantProducto);
                cmd.Parameters.AddWithValue("@PrecioUnitario", dProd.precUnitario);
                cmd.Parameters.AddWithValue("@PrecioDescuento", dProd.precDescuento);
                cmd.Parameters.AddWithValue("@PrecioTotal", dProd.precTotal);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public DataTable Cargar(int idMarca)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoriaID", idMarca);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion metodos
    }
}
