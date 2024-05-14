using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public abstract class Usuario
    {
        public int Id {  get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Email = email;
        }
    }
}
