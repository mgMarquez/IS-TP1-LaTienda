using LaTienda.Dominio;
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

        public Cliente BuscarClientePorID(int idClienteGestionar)
        {
            return _unitOfWork.ClienteRepository.GetById(idClienteGestionar);
        }

        public void CrearCliente(Cliente cliente)
        {
            _unitOfWork.ClienteRepository.Create(cliente);
        }

        public void ModificarCliente(Cliente clienteModificado)
        {
            _unitOfWork.ClienteRepository.Update(clienteModificado);
        }

        internal void Iniciar(int idClienteGestionar)
        {
            Cliente cliente;
            if (idClienteGestionar == 0)
            {
                cliente = new Cliente();
            }
            else
            {
                cliente = BuscarClientePorID(idClienteGestionar);
            }
            _vista.MostrarCliente(cliente);
        }

        public void EliminarCliente(int idCliente)
        {
            _unitOfWork.ClienteRepository.Delete(idCliente);
        }

        public Cliente BuscarClientePorNroDocumento(long NroDocumentoCliente)
        {
            return _unitOfWork.ClienteRepository
                .Find(cl => cl.NroDocumento == NroDocumentoCliente)
                .First() ?? throw new NullReferenceException();            
        }
    }
}
