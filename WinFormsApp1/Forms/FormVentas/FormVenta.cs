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

namespace WinFormsApp1.Forms.FormVentas
{
    public partial class FormVenta : Form
    {
        public int idVenta;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            idVenta = 0;
            dgvVenta.AutoGenerateColumns = true;
            dgvVenta.DataSource = VentaData.ListarVenta();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }
    }
}
