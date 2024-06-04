using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.DataBase
{
    internal static class UsuarioData
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True";

        public static List<Usuario> ListarUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            string query = "SELECT * FROM Usuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id = Convert.ToInt32(reader["Id"]);
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.Apellido = reader["Apellido"].ToString();
                            usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                            usuario.Contraseña = reader["Contraseña"].ToString();
                            usuario.Mail = reader["Mail"].ToString();

                            listaUsuario.Add(usuario);
                        }
                    }
                }
            }
            return listaUsuario;
        }
        public static Usuario ObtenerUsuario(int id)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("id", id);
                conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idUsuario = Convert.ToInt32(reader[0]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string contraseña = reader.GetString(4);
                    string mail = reader.GetString(5);


                    Usuario usuario = new Usuario(idUsuario, nombre, apellido, nombreUsuario, contraseña, mail);
                    return usuario;
                }
                throw new Exception("El ID no fue encontrado");
            }
        }
        public static bool CrearUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuario(nombre,apellido,nombreUsuario,contraseña,mail) values(@nombre,@apellido,@nombreUsuario,@contraseña,@mail)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("mail", usuario.Mail);

                conexion.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool ModificarUsuario(int id, Usuario usuario)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @comentarios,IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conexion);

                command.Parameters.AddWithValue("id", id);

                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("mail", usuario.Mail);

                conexion.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, conexion);
                conexion.Open();
                command.Parameters.AddWithValue("id", idUsuario);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}