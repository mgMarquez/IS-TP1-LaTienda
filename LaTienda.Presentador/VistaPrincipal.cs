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
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var vista = new ClienteVista(new UnitOfWork());
            var vista = new GestionarClienteVista(new UnitOfWork())
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized                
            };
            vista.Show();
        }

        private void NuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vista = new RegistrarVentaVista(new UnitOfWork())
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            vista.Show();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vista = new GestionarProductoVista(new UnitOfWork())
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            vista.ShowDialog();
        }
    }
}
