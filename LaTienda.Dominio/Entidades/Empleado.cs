using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        private string _contraseña;

        public Empleado(int empleadoID, int legajo, string nombre)
        {
            EmpleadoID = empleadoID;
            Legajo = legajo;
            Nombre = nombre;
        }

        public Empleado(string contraseña)
        {
            _contraseña = contraseña;
        }

        public bool VerificarContraseña(string contraseña)
        {
            return _contraseña == contraseña;
        }
    }
}
