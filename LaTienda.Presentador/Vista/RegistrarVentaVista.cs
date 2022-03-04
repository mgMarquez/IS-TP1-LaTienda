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

namespace LaTienda.Presentador
{
    public partial class RegistrarVentaVista : Form, IRegistrarVentaVista
    {
        private readonly ControladorRegistrarVenta _controladorRegistrarVenta;

        public RegistrarVentaVista(IUnitOfWork unitOfWork)
        {
            _controladorRegistrarVenta = new ControladorRegistrarVenta(unitOfWork, this);
            _controladorRegistrarVenta.IniciarVenta();
            InitializeComponent();
        }

        public void MostrarDetalleDeVenta(List<LineaDeVenta> detalleVenta)
        {
            dataGVDetalleVenta.DataSource = null;
            dataGVDetalleVenta.DataSource = detalleVenta;
        }

        public void MostrarProductoEnStock(Producto productoEnStock)
        {
            bsProducto.DataSource = productoEnStock;
            bsMarca.DataSource = productoEnStock.Marca;
            bsRubro.DataSource = productoEnStock.Rubro;            
        }

        private void BtBuscarProducto_Click(object sender, EventArgs e)
        {
            int codigoProducto = Convert.ToInt32(tbCodigo.Text);
            _controladorRegistrarVenta.BuscarProducto(codigoProducto);
        }

        private void CbTalle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbTalle.SelectedItem is Talle talleSeleccionado)) return;
            _controladorRegistrarVenta.SeleccionarTalle(talleSeleccionado);
        }

        private void CbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbColor.SelectedItem is Dominio.Color colorSeleccionado)) return;
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

        private void BtAgregarProducto_Click(object sender, EventArgs e)
        {
            int cantidadAgregar = (int)nudCantidadProductos.Value;
            var color = cbColor.SelectedItem as Dominio.Color;
            var talle = cbTalle.SelectedItem as Talle;
            _controladorRegistrarVenta.AgregarProductoVenta(color, talle, cantidadAgregar);
        }

        public void MostrarTotalAPagar(double total, double iva, double netoGravado)
        {
            tbTotal.Text = Convert.ToString(total);            
            tbIva.Text = Convert.ToString(iva);            
            tbNeto.Text = Convert.ToString(netoGravado);
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            _controladorRegistrarVenta.FinalizarVenta();
        }
    }
}
