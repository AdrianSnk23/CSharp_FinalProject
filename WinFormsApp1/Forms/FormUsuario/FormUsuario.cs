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

namespace WinFormsApp1.Forms.FormUsuario
{
    public partial class FormUsuario : Form
    {
        public int idUsuario;
        public FormUsuario()
        {
            InitializeComponent();
        }


        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = UsuarioData.ListarUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormUsuarioCRUD formUsuarioCRUD = new FormUsuarioCRUD();
            formUsuarioCRUD.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Refresh();
            dgvUsuarios.DataSource = UsuarioData.ListarUsuario();
            dgvUsuarios.AutoGenerateColumns = true;
        }
    }
}
