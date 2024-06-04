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

namespace WinFormsApp1.Forms.FormProducto
{
    public partial class FormProductoCRUD : Form
    {
        public FormProductoCRUD()
        {
            InitializeComponent();
        }

        public void Clean()
        {
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
        }

        private void FormProductoCRUD_Load(object sender, EventArgs e)
        {
            int idProducto = Form1.formProducto.idProducto;
            if (idProducto > 0)
            {
                Producto txtProducto = ProductoData.ObtenerProducto(idProducto);

                txtDescripcion.Text = txtProducto.Descripcion;
                txtCosto.Text = txtProducto.Costo.ToString();
                txtPrecioVenta.Text = txtProducto.PrecioVenta.ToString();
                txtStock.Text = txtProducto.Stock.ToString();
                txtIdUsuario.Text = txtProducto.IdUsuario.ToString();

                txtId.Text = idProducto.ToString();

            }
            else
            {
                Clean();
            }
        }

        private void btnVolverForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.formProducto.idProducto = 0;
            Form1.formProducto.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            ProductoData.EliminarProducto(int.Parse(id));
            MessageBox.Show("Se eliminó el producto");
            Clean();
            Form1.formProducto.idProducto = 0;
            this.Close();
            Form1.formProducto.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            int idProducto = Form1.formProducto.idProducto;
            Producto nuevoProducto = new Producto(descripcion, costo, precioVenta, stock, idProducto);

            if (idProducto > 0) 
            {
                ProductoData.ObtenerProducto(idProducto);
                MessageBox.Show("Se actualizó el producto");
            }
            else
            {
                ProductoData.CrearProducto(nuevoProducto);
                MessageBox.Show("Se ha creado un nuevo producto.");
            }
            Clean();
            this.Close();
            Form1.formProducto.idProducto = 0;
            Form1.formProducto.Show();
        }
    }
}
