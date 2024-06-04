using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DataBase;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms.FormUsuario
{
    public partial class FormUsuarioCRUD : Form
    {
        public FormUsuarioCRUD()
        {
            InitializeComponent();
        }
        public void Clean()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtMail.Text = "";
        }

        private void FormUsuarioCRUD_Load(object sender, EventArgs e)
        {
            int idUsuario = Form1.formUsuario.idUsuario;
            if (idUsuario > 0) 
            {
                Usuario txtUsuario = UsuarioData.ObtenerUsuario(idUsuario);

                txtNombre.Text = txtUsuario.Nombre;
                txtApellido.Text = txtUsuario.Apellido;
                txtNombreUsuario.Text = txtUsuario.NombreUsuario;
                txtContraseña.Text = txtUsuario.Contraseña;
                txtMail.Text = txtUsuario.Mail;

                txtIdUsuario.Text = idUsuario.ToString();
            }
            else
            {
                Clean();
            }
        }
    }
}
