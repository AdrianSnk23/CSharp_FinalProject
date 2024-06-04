using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.DataBase
{
    internal static class ProductoVendidoData
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True";

        public static List<ProductoVendido> ListarProductoVendido()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string query = "SELECT * FROM ProductoVendido";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoVendido productoVendido = new ProductoVendido();

                            productoVendido.Id = Convert.ToInt32(reader["ID"]);
                            productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                            productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                            productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);

                            lista.Add(productoVendido);
                        }
                    }
                }
            }
            return lista;
        }
        public static ProductoVendido ObtenerProductoVendido(int id)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("id", id);
                conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idProductoVendido = Convert.ToInt32(reader[0]);
                    int stock = Convert.ToInt32(reader[1]);
                    int idProducto = Convert.ToInt32(reader[2]);
                    int idVenta = Convert.ToInt32(reader[3]);

                    ProductoVendido productoVendido = new ProductoVendido(idProductoVendido, stock, idProducto, idVenta);
                    return productoVendido;
                }
                throw new Exception("El ID no fue encontrado");
            }
        }
        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ProductoVendido(Stock, IdProducto,IdVenta) values(@stock,@idProducto,@idVenta)";
                SqlCommand command = new SqlCommand(query, conexion);

                command.Parameters.AddWithValue("@Stock", productoVendido.Stock);
                command.Parameters.AddWithValue("@idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("@IdVenta", productoVendido.IdVenta);
                
                conexion.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool ModificarProductoVendido(int id, ProductoVendido productoVendido)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock,IdProducto = @idProduct,IdVenta = sellId WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);

                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("Stock", productoVendido.Stock);
                command.Parameters.AddWithValue("idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);
                

                conexion.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool EliminarProductoVendido(int idProductoVendido)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ProductoVendido WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, conexion);
                conexion.Open();
                command.Parameters.AddWithValue("id", idProductoVendido);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}