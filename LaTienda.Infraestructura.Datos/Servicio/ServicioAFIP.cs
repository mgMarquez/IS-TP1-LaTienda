using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos.WSAFIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Infraestructura.Datos.Servicio
{
    public static class ServicioAFIP
    {

        public static void SolicitarAutorizacionComprobante(Venta venta, Comprobante comprobante)
        {
            var auth = ObtenerAutorizacion();

            var servicioAfip = new WSAFIP.ServiceSoapClient();

            int puntoVenta = new PuntoDeVenta().NumeroPDV; //cambiar
            int comprobanteTipo = (int) new Comprobante().TipoComprobante; //cambiar

            var ultimoAutorizado = servicioAfip.FECompUltimoAutorizado(auth, puntoVenta, comprobanteTipo);
            var ultimoNumCompAut = ultimoAutorizado.CbteNro;

            comprobante.AsignarNumeroComprobante(ultimoNumCompAut);

            // Informacíón del comprobante. Cabezera y detalle del comprobante
            var feCAEReq = new WSAFIP.FECAERequest
            {
                FeCabReq = CrearCabeceraDeComprobante(comprobante), // cabezera
                FeDetReq = CrearDetalleDelComprobante(comprobante) // detalle
            };

            WSAFIP.FECAEResponse feCAESolicitar = servicioAfip.FECAESolicitar(auth, feCAEReq);

            // TODO: continuar con lo que sigue de la autorización
        }

        private static WSAFIP.FEAuthRequest ObtenerAutorizacion()
        {
            // web service de autorización y autenticación
            var servicioAutorizacion = new WSAA.LoginServiceClient();
            // solicitud de autorización al servicio externo
            var certificadoAutorizacion = servicioAutorizacion.SolicitarAutorizacion("C116B5BE-3AE2-4C89-B1C7-424A4A842D48");
            // adapta el certificado de autorización
            var auth = new WSAFIP.FEAuthRequest()
            {
                Cuit = certificadoAutorizacion.Cuit,
                Sign = certificadoAutorizacion.Sign,
                Token = certificadoAutorizacion.Token
            };
            return auth;
        }

        private static FECAECabRequest CrearCabeceraDeComprobante(Comprobante comprobante)
        {
            return new FECAECabRequest()
            {
                CantReg = 1,
                CbteTipo = (int)comprobante.TipoComprobante,
                PtoVta = comprobante.PuntoDeVenta
            };
        }

        private static FECAEDetRequest[] CrearDetalleDelComprobante(Comprobante comprobante)
        {
            return new FECAEDetRequest[]
            {
                new FECAEDetRequest()
                {
                    Concepto = 1, // 1 Productos
                    DocTipo = comprobante.NumeroDeComprobante,
                    DocNro = comprobante.NumeroDeComprobante,
                    CbteFch = comprobante.FechaStringYYYYMMDD,
                    ImpTotal = 0, // COMPLETAR
                    ImpTotConc = 0,
                    ImpNeto = 0,
                    ImpOpEx = 0,
                    ImpIVA = 0,
                    ImpTrib = 0,
                    MonId = "PES",
                    MonCotiz = 1, // para pesos argentinos es 1
                }
            };
        }
    }
}
