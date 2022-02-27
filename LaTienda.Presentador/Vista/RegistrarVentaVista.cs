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
using LaTienda.Infraestructura.Datos;

namespace LaTienda.Presentador.Vista
{
    public partial class RegistrarVentaVista : Form, IRegistrarVentaVista
    {
        private readonly ControladorRegistrarVenta _controladorRegistrarVenta;

        public RegistrarVentaVista(IUnitOfWork unitOfWork)
        {
            _controladorRegistrarVenta = new ControladorRegistrarVenta(unitOfWork, this);
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
            bsProducto.DataSource = productoActual;
            bsMarca.DataSource = productoActual.Marca.Descripcion;
            bsRubro.DataSource = productoActual.Rubro.Descripcion;
        }

        public void QuitarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        private void BtBuscarProducto_Click(object sender, EventArgs e)
        {
            int codigoProducto = Convert.ToInt32(tbCodigo.Text);
            _controladorRegistrarVenta.BuscarProducto(codigoProducto);
        }
    }
}
