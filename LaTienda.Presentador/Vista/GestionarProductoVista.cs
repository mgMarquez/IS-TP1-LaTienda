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
            //var vistaCliente = new ClienteVista();
            //vistaCliente.EventoConfirmar += _controlador.CrearCliente;
            //vistaCliente.MostrarCliente(new Cliente());
            //vistaCliente.VistaCrear();
            //vistaCliente.ShowDialog();
        }

        private void ToolStripButtonModificar_Click(object sender, EventArgs e)
        {
            //Cliente clienteActual = DgvCliente.CurrentRow?.DataBoundItem as Cliente;
            //if (clienteActual == null) return;
            //var vistaCliente = new ClienteVista();
            //vistaCliente.EventoConfirmar += _controlador.ModificarCliente;
            //vistaCliente.MostrarCliente(clienteActual);
            //vistaCliente.VistaModificar();
            //vistaCliente.ShowDialog();
        }

        private void ToolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            //Cliente clienteActual = DgvCliente.CurrentRow?.DataBoundItem as Cliente;
            //if (clienteActual == null) return;
            //var vistaCliente = new ClienteVista();
            //vistaCliente.EventoConfirmar += _controlador.EliminarCliente;
            //vistaCliente.MostrarCliente(clienteActual);
            //vistaCliente.VistaEliminar();
            //vistaCliente.ShowDialog();
        }
    }
}
