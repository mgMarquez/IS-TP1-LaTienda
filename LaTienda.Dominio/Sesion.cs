using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Sesion
    {
        public static Empleado Empleado { get; private set; }

        public static void AsignarEmpleado(Empleado empleado)
        {
            Empleado = empleado;
        }
    }
}
