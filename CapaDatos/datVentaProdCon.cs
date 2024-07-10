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
    public class datVentaProdCon
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datVentaProdCon _instancia = new datVentaProdCon();
        //privado para evitar la instanciación directa
        public static datVentaProdCon Instancia
        {
            get
            {
                return datVentaProdCon._instancia;
            }
        }
        #endregion singleton

        #region VENTACSLT

        ////////////////////listado de VentaProducto
        public List<entVentaProdCon> ListarVentaProducto()
        {
            SqlCommand cmd = null;
            List<entVentaProdCon> lista = new List<entVentaProdCon>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarConsultaVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVentaProdCon Vet = new entVentaProdCon();
                    entProducto Pro = new entProducto();
                    entCategoria Cat = new entCategoria();
                    entMarca Mar = new entMarca();
                    entMetodoPago Met = new entMetodoPago();

                    // Asignar datos a entVentaProducto
                    Vet.estVenta = Convert.ToBoolean(dr["estVenta"]);
                    Vet.FechaVenProd = Convert.ToDateTime(dr["FechaVenProd"]);
                    Vet.DetalleVentaproductoID = Convert.ToInt32(dr["DetalleVentaproductoID"]);
                    Vet.VentaproductoID = Convert.ToInt32(dr["VentaproductoID"]);
                    Vet.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);

                    // Asignar datos a entProducto
                    Pro.NomPro = dr["NomProducto"].ToString();
                    Vet.Producto = Pro; // Asumimos que hay una propiedad Producto en entVentaProducto

                    // Asignar datos a entCategoria
                    Cat.NomCategoria = dr["NomCategoria"].ToString();
                    Vet.Categoria = Cat; // Asumimos que hay una propiedad Categoria en entVentaProducto

                    // Asignar datos a entMarca
                    Mar.nomMarca = dr["NomMarca"].ToString();
                    Vet.Marca = Mar; // Asumimos que hay una propiedad Marca en entVentaProducto

                    // Asignar datos a entMetodoPago
                    Met.nombre = dr["NomMetodo"].ToString();
                    Vet.MetodoPago = Met; // Asumimos que hay una propiedad MetodoPago en entVentaProducto

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

        //Busqueda de VentaProducto
        public List<entVentaProdCon> BuscarVentaProducto(bool? estVenta, DateTime? FechaVenProd, int? DetalleventaproductoID, int? VentaproductoID, string NomProducto, string NomCategoria, string NomMarca, string NomMetodo)
        {
            SqlCommand cmd = null;
            List<entVentaProdCon> lista = new List<entVentaProdCon>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarConsultaVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agrega los parámetros al comando
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

                    // Asignar datos a entVentaProducto
                    Vet.estVenta = Convert.ToBoolean(dr["estVenta"]);
                    Vet.FechaVenProd = Convert.ToDateTime(dr["FechaVenProd"]);
                    Vet.DetalleVentaproductoID = Convert.ToInt32(dr["DetalleventaproductoID"]);
                    Vet.VentaproductoID = Convert.ToInt32(dr["VentaproductoID"]);
                    Vet.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);

                    // Asignar datos a entProducto
                    Pro.NomPro = dr["NomProducto"].ToString();
                    Vet.Producto = Pro; // Asumimos que hay una propiedad Producto en entVentaProducto

                    // Asignar datos a entCategoria
                    Cat.NomCategoria = dr["NomCategoria"].ToString();
                    Vet.Categoria = Cat; // Asumimos que hay una propiedad Categoria en entVentaProducto

                    // Asignar datos a entMarca
                    Mar.nomMarca = dr["NomMarca"].ToString();
                    Vet.Marca = Mar; // Asumimos que hay una propiedad Marca en entVentaProducto

                    // Asignar datos a entMetodoPago
                    Met.nombre = dr["NomMetodo"].ToString();
                    Vet.MetodoPago = Met; // Asumimos que hay una propiedad MetodoPago en entVentaProducto

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
        #endregion VENTACSLT
    }
}
