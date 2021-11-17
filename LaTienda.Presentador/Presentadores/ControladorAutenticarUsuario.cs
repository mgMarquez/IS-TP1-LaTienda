using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorAutenticarUsuario
    {
        private readonly IRepositorio _presistencia;
        private readonly IAutenticarUsuarioVista _vista;

        public ControladorAutenticarUsuario(IRepositorio repositorio, IAutenticarUsuarioVista vista)
        {
            _presistencia = repositorio;
            _vista = vista;
        }

        public void SolicitarAcceso(int legajo, string contraseña)
        {
            var empleado = _presistencia.BuscarEmpleado(legajo);
            empleado.VerificarContraseña(contraseña);
            Sesion.AsignarEmpleado(empleado);
        }
    }
}
