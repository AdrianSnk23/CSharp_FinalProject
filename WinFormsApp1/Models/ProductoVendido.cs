using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class ProductoVendido
    {
        private int _id;
        private int _stock;
        private int _idProducto;
        private int _idVenta;

        public ProductoVendido()
        {
        }

        public ProductoVendido(int stock, int idProducto, int idVenta)
        {
            this._stock = stock;
            this._idProducto = idProducto;
            this._idVenta = idVenta;
        }

        public ProductoVendido(int id, int stock, int idProducto, int idVenta) : this(stock, idProducto, idVenta)
        {
            this._id = id;

        }

        public int Id { get => _id; set => _id = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int IdVenta { get => _idVenta; set => _idVenta = value; }
    }

}