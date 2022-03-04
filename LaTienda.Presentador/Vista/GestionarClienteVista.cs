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
        }

        public void MostrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
