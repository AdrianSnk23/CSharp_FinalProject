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

namespace WinFormsApp1.Forms.FormProductoVendido
{
    public partial class FormProductoVendido : Form
    {
        public int idProductoVendido;
        public FormProductoVendido()
        {
            InitializeComponent();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void dgvProductoVendido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            idProductoVendido = 0;
            dgvProductoVendido.AutoGenerateColumns = true;
            dgvProductoVendido.DataSource = ProductoVendidoData.ListarProductoVendido();
        }
    }
}
