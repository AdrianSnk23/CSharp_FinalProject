using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1.DataBase
{
    internal static class ProductoData
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True";

        public static List<Producto> ListarProducto()
        {
            List<Producto> lista = new List<Producto>();
            string query = "SELECT * FROM Producto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto();

                            producto.Id = Convert.ToInt32(reader["Id"]);
                            producto.Descripcion = reader["Descripciones"].ToString();
                            producto.Costo = Convert.ToDouble(reader["Costo"]);
                            producto.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                            producto.Stock = Convert.ToInt32(reader["Stock"]);
                            producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                            lista.Add(producto);
                        }
                    }
                }
            }
            return lista;
        }
        public static Producto ObtenerProducto(int id)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            {
                string query = "SELECT * FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query,conexion);
                command.Parameters.AddWithValue("id", id);
                conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                {
                    int idProducto = Convert.ToInt32(reader[0]);
                    string descripcion = reader.GetString(1);
                    double costo = Convert.ToDouble(reader[2]);
                    double precioVenta = Convert.ToDouble(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUsuario = Convert.ToInt32(reader[5]);

                    Producto producto = new Producto(idProducto, descripcion, costo, precioVenta, stock, idUsuario);
                    return producto;
                }
                throw new Exception("El ID no fue encontrado");
            }
        }
        public static bool CrearProducto(Producto producto)
        {
            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@descripciones, @costo, @precioVenta, @stock, @idUsuario)";
            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand (query,conexion);
                command.Parameters.AddWithValue("Descripciones", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);

                conexion.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool ModificarProducto(int id, Producto producto)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @description, Costo = @cost, PrecioVenta = @sellPrice, Stock = @stock, IdUsuario = @userId WHERE Id = @id";
                SqlCommand command = new SqlCommand(query,conexion);

                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);

                conexion.Open();
                return command.ExecuteNonQuery()>0;
            }
        }
        public static bool EliminarProducto(int idProducto)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id=@id";
                SqlCommand command = new SqlCommand (query,conexion);
                conexion.Open();
                command.Parameters.AddWithValue("id", idProducto);

                return command.ExecuteNonQuery()>0;
            }
        }
    }
}
