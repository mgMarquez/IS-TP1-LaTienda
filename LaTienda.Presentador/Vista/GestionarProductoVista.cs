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
        private readonly ControladorGestionarProducto _controladorGestionarProducto;

        public GestionarProductoVista(IUnitOfWork unitOfWork)
        {
            _controladorGestionarProducto = new ControladorGestionarProducto(unitOfWork, this);
            InitializeComponent();
        }


    }
}
