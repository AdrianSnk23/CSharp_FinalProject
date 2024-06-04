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

namespace WinFormsApp1.Forms.FormProducto
{
    public partial class FormProducto : Form
    {
        public int idProducto;
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            idProducto = 0;
            dgvProducto.AutoGenerateColumns = true;
            dgvProducto.DataSource = ProductoData.ListarProducto();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.formProducto.idProducto = 0;
            Program.form1.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvProducto.DataSource = null;
            dgvProducto.Refresh();
            dgvProducto.DataSource = ProductoData.ListarProducto();
            dgvProducto.AutoGenerateColumns = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormProductoCRUD formProductoCRUD = new FormProductoCRUD();
            Form1.formProducto.Hide();
            formProductoCRUD.Show();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    int filaSeleccionada = (int)e.RowIndex;
                    idProducto = int.Parse(dgvProducto[0, filaSeleccionada].Value.ToString());
                }
                FormProductoCRUD formProductoCRUD = new FormProductoCRUD();
                Form1.formProducto.Hide();
                formProductoCRUD.Show();
            }
        }
    }
}
