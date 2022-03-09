using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = LaTienda.Dominio.Color;

namespace LaTienda.Presentador
{
    public partial class GestionarStockVista : Form, IGestionarStockVista
    {
        private readonly ControladorGestionarStock _controlador;

        public GestionarStockVista(IUnitOfWork unitOfWork)
        {
            _controlador = new ControladorGestionarStock(unitOfWork, this);
            InitializeComponent();
            BuscarStocks();
        }

        public void MostrarListaStocks(List<Stock> stocks)
        {
            DgvStock.DataSource = stocks;
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarStocks();
        }

        private void BuscarStocks()
        {
            var filtro = TbBuscar.Text;
            _controlador.BuscarStocks(filtro);
        }

        private void ToolStripButtonCrear_Click(object sender, EventArgs e)
        {
            var vistaStock = new StockVista();
            var productos = _controlador.BuscarProductosDisponibles();
            var talles = _controlador.BuscarTallesDisponibles();
            var colores = _controlador.BuscarColoresDisponibles();
            vistaStock.VistaCrear();
            vistaStock.MostrarProductos(productos);
            vistaStock.MostrarColores(colores);
            vistaStock.MostrarTalles(talles);
            vistaStock.MostrarStock(new Stock());
            vistaStock.EventoConfirmar += _controlador.CrearStock;
            vistaStock.ShowDialog();
            BuscarStocks();
        }

        private void ToolStripButtonModificar_Click(object sender, EventArgs e)
        {
            Stock stockActual = DgvStock.CurrentRow?.DataBoundItem as Stock;
            if (stockActual == null) return;
            var vistaStock = new StockVista();
            var productos = _controlador.BuscarProductosDisponibles();
            var talles = _controlador.BuscarTallesDisponibles();
            var colores = _controlador.BuscarColoresDisponibles();
            vistaStock.VistaModificar();
            vistaStock.MostrarProductos(productos);
            vistaStock.MostrarColores(colores);
            vistaStock.MostrarTalles(talles);
            vistaStock.MostrarStock(stockActual);
            vistaStock.EventoConfirmar += _controlador.ModificarStock;
            vistaStock.ShowDialog();
            BuscarStocks();
        }

        private void ToolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            Stock stockActual = DgvStock.CurrentRow?.DataBoundItem as Stock;
            if (stockActual == null) return;
            var vistaStock = new StockVista();
            var productos = new List<Producto> { stockActual.Producto };
            var talles = new List<Talle> { stockActual.Talle};
            var colores = new List<Color> { stockActual.Color };
            vistaStock.VistaEliminar();
            vistaStock.MostrarProductos(productos);
            vistaStock.MostrarColores(colores);
            vistaStock.MostrarTalles(talles);
            vistaStock.MostrarStock(stockActual);
            vistaStock.EventoConfirmar += _controlador.EliminarStock;
            vistaStock.ShowDialog();
            BuscarStocks();
        }
    }
}
