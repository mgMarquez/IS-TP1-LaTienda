using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorGestionarCliente
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGestionarClienteVista _vista;

        public ControladorGestionarCliente(IUnitOfWork unitOfWork, IGestionarClienteVista vista)
        {
            _unitOfWork = unitOfWork;
            _vista = vista;
        }
    }
}
