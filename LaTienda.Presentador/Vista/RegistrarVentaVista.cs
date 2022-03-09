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
        private readonly ControladorRegistrarVenta _controlador;

        public RegistrarVentaVista(IUnitOfWork unitOfWork)
        {
            _controlador = new ControladorRegistrarVenta(unitOfWork, this);
            _controlador.IniciarVenta();
            InitializeComponent();
            _controlador.MostrarCliente();
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
            _controlador.BuscarProducto(codigoProducto);
        }

        private void CbTalle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbTalle.SelectedItem is Talle talleSeleccionado)) return;
            _controlador.SeleccionarTalle(talleSeleccionado);
        }

        private void CbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbColor.SelectedItem is Dominio.Color colorSeleccionado)) return;
            _controlador.SeleccionarColor(colorSeleccionado);
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
            int cantidadAgregar = Convert.ToInt32(TbCantidadAgregar.Text);
            var color = cbColor.SelectedItem as Dominio.Color;
            var talle = cbTalle.SelectedItem as Talle;
            _controlador.AgregarProductoVenta(color, talle, cantidadAgregar);
        }

        public void MostrarTotalAPagar(Venta venta)
        {
            //tbTotal.Text = Convert.ToString(total);            
            //tbIva.Text = Convert.ToString(iva);            
            //tbNeto.Text = Convert.ToString(netoGravado);
            BsVenta.DataSource = venta;
            BsVenta.ResetBindings(false);
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            _controlador.FinalizarVenta();
        }

        public void MostrarCliente(Cliente cliente)
        {
            BsCliente.DataSource = cliente;
        }

        public void MensajeInformativo(string msj)
        {
            MessageBox.Show(msj, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            var esNumero = Int64.TryParse(TbNroDocumento.Text, out long nroDocumento);
            if (!esNumero) return;
            _controlador.AsignarClienteVenta(nroDocumento);
            BsCliente.ResetBindings(false);
        }

        private void BtQuitar_Click(object sender, EventArgs e)
        {
            LineaDeVenta lineaDeVentaSeleccionada = dataGVDetalleVenta.CurrentRow.DataBoundItem as LineaDeVenta;
            if (lineaDeVentaSeleccionada == null) return;
            _controlador.QuitarLineaDeVenta(lineaDeVentaSeleccionada);
        }
    }
}
