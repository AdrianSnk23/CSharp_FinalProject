using WinFormsApp1.Forms.FormProducto;
using WinFormsApp1.Forms.FormProductoVendido;
using WinFormsApp1.Forms.FormUsuario;
using WinFormsApp1.Forms.FormVentas;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static FormProducto formProducto = new FormProducto();
        public static FormUsuario formUsuario = new FormUsuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProducto formProducto = new FormProducto();
            formProducto.Show();
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductoVendido formProductoVendido = new FormProductoVendido();
            formProductoVendido.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenta formVenta = new FormVenta();
            formVenta.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
