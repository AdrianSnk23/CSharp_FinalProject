using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto() { }

        public Producto(string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {

            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario) : this(descripcion, costo, precioVenta, stock, idUsuario)
        {
            this._id = id;
        }


        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public override string ToString()
        {
            return $"Id = {this._id} - Descripciones = {this._descripcion} - Costo = {this._costo} - PrecioVenta = {this._precioVenta}  - Stock = {this._stock} - IdUsuario = {this._idUsuario}";
        }
    }
}