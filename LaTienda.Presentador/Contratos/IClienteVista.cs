using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public interface IClienteVista
    {
        void MostrarCliente(Cliente cliente);
    }
}