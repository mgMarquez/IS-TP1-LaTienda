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
    public partial class ClienteVista : Form, IClienteVista
    {
        private readonly ControladorGestionarCliente _controlador;
        private Cliente _cliente;
        public int IdClienteGestionar { private get; set; }

        public ClienteVista()
        {
            InitializeComponent();
            CbCondicionTributaria.DataSource = Enum.GetValues(typeof(CondicionTributaria));
            CbTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
        }

        public void MostrarCliente(Cliente cliente)
        {
            try
            {
                _cliente = cliente ?? throw new ArgumentNullException();
                BsCliente.DataSource = _cliente;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            _cliente = new Cliente();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                _cliente = _controlador.BuscarClientePorNroDocumento(Convert.ToInt64(TbNroDocumento.Text));
                BsCliente.DataSource = _cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro ningun cliente con ese nro de documento.", ex.Message);
            }
        }
    }
}
