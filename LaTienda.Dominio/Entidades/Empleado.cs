using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public abstract class Empleado
    {
        public int EmpleadoID { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        private string _contrasenia;

        public Empleado(int empleadoID, int legajo, string nombre)
        {
            EmpleadoID = empleadoID;
            Legajo = legajo;
            Nombre = nombre;
        }

        public void EstablecerContrasenia(string contrasenia)
        {
            _contrasenia = contrasenia;
        }

        public bool VerificarContraseña(string contrasenia)
        {
            return _contrasenia == contrasenia;
        }
    }
}
