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
    public partial class GestionarClienteVista : Form, IGestionarClienteVista
    {
        private readonly ControladorGestionarCliente _controlador;

        public GestionarClienteVista(IUnitOfWork unitOfWork)
        {
            _controlador = new ControladorGestionarCliente(unitOfWork, this);
            InitializeComponent();
            BuscarClientes();
        }

        public void MostrarListaClientes(List<Cliente> clientes)
        {
            DgvCliente.DataSource = clientes;
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            var filtro = TbBuscar.Text;
            _controlador.BuscarClientes(filtro);
        }

        private void ToolStripButtonCrear_Click(object sender, EventArgs e)
        {
            var vistaCliente = new ClienteVista();
            vistaCliente.EventoConfirmar += _controlador.CrearCliente;
            vistaCliente.MostrarCliente(new Cliente());
            vistaCliente.VistaCrear();
            vistaCliente.ShowDialog();
            BuscarClientes();
        }

        private void ToolStripButtonModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteActual = DgvCliente.CurrentRow?.DataBoundItem as Cliente;
            if (clienteActual == null) return;
            var vistaCliente = new ClienteVista();
            vistaCliente.EventoConfirmar += _controlador.ModificarCliente;
            vistaCliente.MostrarCliente(clienteActual);
            vistaCliente.VistaModificar();
            vistaCliente.ShowDialog();
            BuscarClientes();
        }

        private void ToolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteActual = DgvCliente.CurrentRow?.DataBoundItem as Cliente;
            if (clienteActual == null) return;
            var vistaCliente = new ClienteVista();
            vistaCliente.EventoConfirmar += _controlador.EliminarCliente;
            vistaCliente.MostrarCliente(clienteActual);
            vistaCliente.VistaEliminar();
            vistaCliente.ShowDialog();
            BuscarClientes();
        }
    }
}
