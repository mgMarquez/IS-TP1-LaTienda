using LaTienda.Infraestructura.Datos;
using LaTienda.Presentador.Vista;
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
            //ServicioAFIP.SolicitarAutorizacionComprobante(new Dominio.Comprobante());
            Application.Run(new RegistrarVentaVista(unitOfWork));
        }
    }
}
