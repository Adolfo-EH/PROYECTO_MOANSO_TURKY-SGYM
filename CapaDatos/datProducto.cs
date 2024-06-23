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
    public class datProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto pr = new entProducto();
                    pr.idProducto = Convert.ToInt32(dr["IDProducto"]);
                    pr.idCategoria = Convert.ToInt32(dr["IDCategoria"]);
                    pr.marca = dr["Marca"].ToString();
                    pr.tipo = dr["Tipo"].ToString();
                    pr.cantidad = Convert.ToInt32(dr["Cantidad"]);
                    pr.precio = Convert.ToDouble(dr["Precio"]);
                    pr.estProducto = Convert.ToBoolean(dr["estProducto"]);
                    lista.Add(pr);
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

        public Boolean InsertarProducto(entProducto pr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCategoria", pr.idCategoria);
                cmd.Parameters.AddWithValue("@marca", pr.marca);
                cmd.Parameters.AddWithValue("@tipo", pr.tipo);
                cmd.Parameters.AddWithValue("@cantidad", pr.cantidad);
                cmd.Parameters.AddWithValue("@precio", pr.precio);
                cmd.Parameters.AddWithValue("@estProducto", pr.estProducto);
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


        //////////////////////////////////EditaCliente
        public Boolean EditarProducto(entProducto pr)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDProducto", pr.idProducto);
                cmd.Parameters.AddWithValue("@IDCategoria", pr.idCategoria);
                cmd.Parameters.AddWithValue("@marca", pr.marca);
                cmd.Parameters.AddWithValue("@tipo", pr.tipo);
                cmd.Parameters.AddWithValue("@cantidad", pr.cantidad);
                cmd.Parameters.AddWithValue("@precio", pr.precio);
                cmd.Parameters.AddWithValue("@estProducto", pr.estProducto);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente
        public Boolean DeshabilitarProducto(entProducto pr)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", pr.idProducto);
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
        #endregion metodos
    }
}
