using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public interface IGestionarClienteVista
    {
        void MostrarCliente(Cliente cliente);
    }
}