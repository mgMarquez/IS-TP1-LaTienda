using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Vendedor : Empleado
    {
        public Vendedor(int empleadoID, int legajo, string nombre) : base(empleadoID, legajo, nombre)
        {
        }
    }
}
