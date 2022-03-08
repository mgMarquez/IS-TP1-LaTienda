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

namespace LaTienda.Presentador
{
    public partial class GestionarProductoVista : Form, IGestionarProductoVista
    {
        private readonly ControladorGestionarProducto _controlador;

        public GestionarProductoVista(IUnitOfWork unitOfWork)
        {
            _controlador = new ControladorGestionarProducto(unitOfWork, this);
            InitializeComponent();
            BuscarProductos();
        }

        public void MostrarListaProductos(List<Producto> productos)
        {
            DgvProducto.DataSource = productos;
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            var filtro = TbBuscar.Text;
            _controlador.BuscarProductos(filtro);
        }

        private void ToolStripButtonCrear_Click(object sender, EventArgs e)
        {
            var vistaProducto = new ProductoVista();
            var marcas = _controlador.BuscarMarcasDisponibles();
            var rubros = _controlador.BuscarRubrosDisponibles();            
            vistaProducto.VistaCrear();
            vistaProducto.MostrarMarcas(marcas);
            vistaProducto.MostrarRubros(rubros);
            vistaProducto.MostrarProducto(new Producto());
            vistaProducto.EventoConfirmar += _controlador.CrearProducto;
            vistaProducto.ShowDialog();
            BuscarProductos();
        }

        private void ToolStripButtonModificar_Click(object sender, EventArgs e)
        {
            Producto productoActual = DgvProducto.CurrentRow?.DataBoundItem as Producto;
            if (productoActual == null) return;
            var vistaProducto = new ProductoVista();
            var marcas = _controlador.BuscarMarcasDisponibles();
            var rubros = _controlador.BuscarRubrosDisponibles();
            vistaProducto.VistaModificar();
            vistaProducto.MostrarMarcas(marcas);
            vistaProducto.MostrarRubros(rubros);
            vistaProducto.MostrarProducto(productoActual);
            vistaProducto.EventoConfirmar += _controlador.ModificarProducto;
            vistaProducto.ShowDialog();
            BuscarProductos();
        }

        private void ToolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            Producto productoActual = DgvProducto.CurrentRow?.DataBoundItem as Producto;
            if (productoActual == null) return;
            var vistaProducto = new ProductoVista();
            var marcas = new List<Marca> { productoActual.Marca};
            var rubros = new List<Rubro> { productoActual.Rubro};
            vistaProducto.VistaEliminar();
            vistaProducto.MostrarMarcas(marcas);
            vistaProducto.MostrarRubros(rubros);
            vistaProducto.MostrarProducto(productoActual);
            vistaProducto.EventoConfirmar += _controlador.EliminarProducto;
            vistaProducto.ShowDialog();
            BuscarProductos();
        }
    }
}
