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

        public void BuscarClientes(string filtro)
        {
            var filtroMinusculas = filtro.ToLower();
            List<Cliente> clientes;
            if (string.IsNullOrEmpty(filtro))
            {
                clientes = _unitOfWork.ClienteRepository.GetAll().ToList();
            }
            else
            {
                clientes = _unitOfWork.ClienteRepository
                    .Find(c => c.NroDocumento.ToString().Contains(filtroMinusculas) || c.RazonSocial.ToLower().Contains(filtroMinusculas)).ToList();
            }

            _vista.MostrarListaClientes(clientes);
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
