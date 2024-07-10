using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logVentaProdCon
    {
        #region singleton
        private static readonly logVentaProdCon _instancia = new logVentaProdCon();
        //privado para evitar la instanciación directa
        public static logVentaProdCon Instancia
        {
            get
            {
                return logVentaProdCon._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entVentaProdCon> ListarVentaProducto()
        {
            return datVentaProdCon.Instancia.ListarVentaProducto();
        }
        public List<entVentaProdCon> BuscarVentaProducto(bool? estVenta, DateTime? FechaVenProd, int? DetalleventaproductoID, int? VentaproductoID, string NomProducto, string NomCategoria, string NomMarca, string NomMetodo)
        {
            SqlCommand cmd = null;
            List<entVentaProdCon> lista = new List<entVentaProdCon>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarConsultaVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@estVenta", (object)estVenta ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaVenProd", (object)FechaVenProd ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DetalleventaproductoID", (object)DetalleventaproductoID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@VentaproductoID", (object)VentaproductoID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NomProducto", (object)NomProducto ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NomCategoria", (object)NomCategoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NomMarca", (object)NomMarca ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NomMetodo", (object)NomMetodo ?? DBNull.Value);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVentaProdCon Vet = new entVentaProdCon();
                    entProducto Pro = new entProducto();
                    entCategoria Cat = new entCategoria();
                    entMarca Mar = new entMarca();
                    entMetodoPago Met = new entMetodoPago();

                    Vet.estVenta = Convert.ToBoolean(dr["estVenta"]);
                    Vet.FechaVenProd = Convert.ToDateTime(dr["FechaVenProd"]);
                    Vet.DetalleVentaproductoID = Convert.ToInt32(dr["DetalleventaproductoID"]);
                    Vet.VentaproductoID = Convert.ToInt32(dr["VentaproductoID"]);
                    Vet.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);

                    Pro.NomPro = dr["NomProducto"].ToString();
                    Vet.Producto = Pro;

                    Cat.NomCategoria = dr["NomCategoria"].ToString();
                    Vet.Categoria = Cat;

                    Mar.nomMarca = dr["NomMarca"].ToString();
                    Vet.Marca = Mar;

                    Met.nombre = dr["NomMetodo"].ToString();
                    Vet.MetodoPago = Met;

                    lista.Add(Vet);
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
        #endregion metodos
    }
}
