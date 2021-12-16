﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PorcentajeDeIva { get; set; }
        public double MargenDeGanancia { get; set; }
        public double NetoGravado => Costo + Costo * MargenDeGanancia;
        public double IVA => NetoGravado * PorcentajeDeIva;
        public double PrecioDeVenta => NetoGravado + IVA;

        public Marca Marca { get; set; }
        public Rubro Rubro { get; set; }
        public List<Stock> DetalleDeStock { get; private set; }

        public Producto(string descripcion, 
            Marca marca, Rubro rubro, double costo, double porcentajeIVA, double margenDeGanancia)
        {
            Descripcion = descripcion;
            Marca = marca;
            Rubro = rubro;
            Costo = costo;
            PorcentajeDeIva = porcentajeIVA;
            MargenDeGanancia = margenDeGanancia;
            DetalleDeStock = new List<Stock>();
        }

        
        public void ActualizarProducto(Producto productoActualizado)
        {
            Descripcion = productoActualizado.Descripcion;
            Marca = productoActualizado.Marca;
            Costo = productoActualizado.Costo;
            PorcentajeDeIva = productoActualizado.PorcentajeDeIva;
            MargenDeGanancia = productoActualizado.MargenDeGanancia;
        }
    }
}
