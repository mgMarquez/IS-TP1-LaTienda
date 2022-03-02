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

        public static void SolicitarAutorizacionComprobante(Comprobante comprobante)
        {
            var auth = ObtenerAutorizacion();
            int puntoVenta = comprobante.PuntoDeVenta;
            int comprobanteTipo = (int)comprobante.TipoComprobante;

            var servicioAfip = new WSAFIP.ServiceSoapClient();
            var ultimoAutorizado = servicioAfip.FECompUltimoAutorizado(auth, puntoVenta, comprobanteTipo);
            int ultimoNumCompAut = ultimoAutorizado.CbteNro; // obtenemos ultimo numero de comprobante
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

        #region Autorización y autenticación con web service cliente
        private static WSAFIP.FEAuthRequest ObtenerAutorizacion()
        {
            // web service de autorización y autenticación
            var servicioAutorizacion = new WSAA.LoginServiceClient();
            // solicitud de autorización al servicio externo
            var certificadoAutorizacion = servicioAutorizacion
                .SolicitarAutorizacion("C116B5BE-3AE2-4C89-B1C7-424A4A842D48");
            // adapta el certificado de autorización
            var auth = new WSAFIP.FEAuthRequest()
            {
                Cuit = certificadoAutorizacion.Cuit,
                Sign = certificadoAutorizacion.Sign,
                Token = certificadoAutorizacion.Token
            };
            return auth;
        }
        #endregion


        #region Información del comprobante - cabecera y detalle
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
                    Concepto = 1, // Concepto del Comprobante - 1 Productos
                    DocTipo = (int)comprobante.DocumentoTipoCliente, // Código de documento identificatorio del comprador
                    DocNro = comprobante.NumeroDocumentoCliente, // Nro. De identificación del comprador
                    CbteDesde = 1,
                    CbteHasta = 1,
                    CbteFch = comprobante.FechaString, // formato yyyyMMdd
                    ImpTotal = comprobante.ImporteTotal,
                    ImpTotConc = comprobante.ImpTotConc,
                    ImpNeto = comprobante.ImpNeto,
                    ImpOpEx = comprobante.ImpOpEx,
                    ImpIVA = comprobante.ImpIVA,
                    ImpTrib = comprobante.ImpTrib,
                    MonId = "PES", // Código de moneda del comprobante - PES para pesos argentinos
                    MonCotiz = 1, // para pesos argentinos es 1
                }
            };
        }
        #endregion
    }
}
