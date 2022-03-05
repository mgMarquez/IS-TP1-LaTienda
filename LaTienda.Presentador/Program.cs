using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTienda.Presentador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new TiendaContext();
            var unitOfWork = new UnitOfWork(context);
            //Application.Run(new RegistrarVentaVista(unitOfWork));
            //Application.Run(new GestionarClienteVista(unitOfWork));
            Application.Run(new VistaPrincipal());

        }
    }
}
