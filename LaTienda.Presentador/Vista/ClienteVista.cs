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
        private Cliente _cliente;
        public event Action<Cliente> EventoConfirmar;

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

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            EventoConfirmar?.Invoke(_cliente);
            this.Close();
        }

        public void VistaModificar()
        {
            labelCliente.Text = "Modificar cliente";
            TbNroDocumento.Enabled = false;
        }

        public void VistaCrear()
        {
            labelCliente.Text = "Crear cliente";
        }

        public void VistaEliminar()
        {
            labelCliente.Text = "¿Desea eliminar el cliente?";
            TbNroDocumento.Enabled = false;
            TbRazonSocial.Enabled = false;
            TbDomicilio.Enabled = false;
            CbCondicionTributaria.Enabled = false;
            CbTipoDocumento.Enabled = false;
        }
    }
}
