﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Comprobante
    {
        public int ComprobanteID { get; set; }
        public int NumeroDeComprobante { get; set; }
        public int PuntoDeVenta { get; set; }
        public DateTime Fecha { get; set; }
        public TipoComprobante TipoComprobante { get; set; }

        public void AsignarNumeroComprobante(int ultimoNumeroComprobante)
        {
            NumeroDeComprobante = ultimoNumeroComprobante + 1;
        }

        public string FechaStringYYYYMMDD => Fecha.ToString("yyyyMMdd");
    }
}
