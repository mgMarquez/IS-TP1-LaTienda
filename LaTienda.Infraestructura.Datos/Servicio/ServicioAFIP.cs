using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Infraestructura.Datos.Servicio
{
    public static class ServicioAFIP
    {

        public static void SolicitarAutorizacion()
        {
            WSAA.LoginServiceClient servicioAutorizacion = new WSAA.LoginServiceClient();
            // solicitud de autorización al servicio externo
            WSAA.Autorizacion certificadoAutorizacion = servicioAutorizacion.SolicitarAutorizacion("C116B5BE-3AE2-4C89-B1C7-424A4A842D48");
            // adapta el certificado de autorización
            WSAFIP.FEAuthRequest auth = new WSAFIP.FEAuthRequest()
            {
                Cuit = certificadoAutorizacion.Cuit,
                Sign = certificadoAutorizacion.Sign,
                Token = certificadoAutorizacion.Token
            };

            WSAFIP.FECAERequest feCAEReq = new WSAFIP.FECAERequest();
            feCAEReq.FeCabReq.CantReg = 1; //Cantidad de registros del detalle del comprobante - siempre 1
            feCAEReq.FeCabReq.CbteTipo = 1; //Tipo de comprobante -- COMPLETAR --
            feCAEReq.FeCabReq.PtoVta = 2; // punto de venta



            WSAFIP.ServiceSoapClient servicioAfip = new WSAFIP.ServiceSoapClient();
            WSAFIP.FECAEResponse feCAESolicitar = servicioAfip.FECAESolicitar(auth, feCAEReq);
        }


    }
}
