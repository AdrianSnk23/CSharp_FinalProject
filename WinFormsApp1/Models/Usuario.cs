using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Usuario
    {

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        public Usuario() { }
        public Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {

            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._mail = mail;
        }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail) : this(nombre, apellido, nombreUsuario, contraseña, mail)
        {
            this._id = id;

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre= value; }
        public string Apellido { get => _apellido; set => _apellido= value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario= value; }
        public string Contraseña { get => _contraseña; set => _contraseña= value; }
        public string Mail { get => _mail; set => _mail = value; }


        public override string ToString()
        {
            return $"Id = {this._id} - Nombre = {this._nombre} - Apellido = {this._apellido} - Nombre de Usuario = {this._nombreUsuario}  - Password = {this._contraseña} - Email = {this._mail}";
        }
    }
}