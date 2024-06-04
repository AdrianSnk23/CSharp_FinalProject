using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.DataBase
{
    internal static class VentaData
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True";

        public static List<Venta> ListarVenta()
        {
            List<Venta> listaVenta = new List<Venta>();
            string query = "SELECT * FROM Venta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta();

                            venta.Id = Convert.ToInt32(reader["Id"]);
                            venta.Comentarios = reader["Comentarios"].ToString();
                            venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            listaVenta.Add(venta);
                        }
                    }
                }
            }
            return listaVenta;
        }
        public static Venta ObtenerVenta(int id)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("id", id);
                conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idVenta = Convert.ToInt32(reader[0]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);

                    Venta venta = new Venta(idVenta, comentarios, idUsuario);
                    return venta;
                }
                throw new Exception("El ID no fue encontrado");
            }
        }
        public static bool CrearVenta(Venta venta)
        {
            string query = "INSERT INTO Venta(Comentarios, IdUsuario) values(@comentarios,@idUsuario)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);

                conexion.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool ModificarVenta(int id, Venta venta)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @comentarios,IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);

                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("Comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);
                

                conexion.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool EliminarVenta(int idVenta)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, conexion);
                conexion.Open();
                command.Parameters.AddWithValue("id", idVenta);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}