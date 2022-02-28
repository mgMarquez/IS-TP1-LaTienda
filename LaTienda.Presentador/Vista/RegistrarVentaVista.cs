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

        public void MostrarDetalleDeVenta(List<LineaDeVenta> detalleVenta)
        {
            throw new NotImplementedException();
        }

        public void MostrarProductoEnStock(Producto productoEnStock)
        {
            bsProducto.DataSource = productoEnStock;
            bsMarca.DataSource = productoEnStock.Marca;
            bsRubro.DataSource = productoEnStock.Rubro;            
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

        private void cbTalle_SelectedValueChanged(object sender, EventArgs e)
        {
            var talleSeleccionado = cbTalle.SelectedItem as Talle;
            if (talleSeleccionado == null) return;
            _controladorRegistrarVenta.SeleccionarTalle(talleSeleccionado);
        }

        private void cbColor_SelectedValueChanged(object sender, EventArgs e)
        {            
            var colorSeleccionado = cbColor.SelectedItem as Dominio.Color;
            if (colorSeleccionado == null) return;
            _controladorRegistrarVenta.SeleccionarColor(colorSeleccionado);
        }

        public void MostrarTallesDisponibles(List<Talle> tallesDisponibles)
        {
            cbTalle.DataSource = tallesDisponibles;
        }

        public void MostrarColoresDisponibles(List<Dominio.Color> coloresDisponibles)
        {
            cbColor.DataSource = coloresDisponibles;
        }

        public void MostrarStockSeleccionado(Stock stockSeleccionado)
        {
            bsStock.DataSource = stockSeleccionado;
        }
    }
}
