using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaTienda.Dominio;

namespace LaTienda.Presentador.Vista
{
    public partial class RegistrarVentaVista : Form, IRegistrarVentaVista
    {
        public RegistrarVentaVista()
        {
            InitializeComponent();
        }

        public void AgregarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void BuscarProducto(string buscar)
        {
            throw new NotImplementedException();
        }

        public void MostrarDetalleDeVenta(List<LineaDeVenta> detalleVenta)
        {
            throw new NotImplementedException();
        }

        public void MostrarProducto(Producto productoActual)
        {
            throw new NotImplementedException();
        }

        public void QuitarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
