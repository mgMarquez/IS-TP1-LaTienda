using System;
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
        public double MargenDeGanancia { get; set; }
        public double NetoGravado { get; set; }
        public double IVA { get; set; }
        public double PrecioDeVenta { get; set; }

        public Marca Marca { get; set; }
        public List<Stock> DetalleDeStock { get; private set; }
        public double PorcentajeDeIva { get; set; }

        public Producto(string descripcion, 
            Marca marca, double costo, double porcentajeIVA, double margenDeGanancia)
        {
            Descripcion = descripcion;
            Marca = marca;
            Costo = costo;
            PorcentajeDeIva = porcentajeIVA;
            MargenDeGanancia = margenDeGanancia;
            DetalleDeStock = new List<Stock>();
            CalcularPrecioVenta();
        }

        public void CalcularNeto()
        {
            NetoGravado = Costo + Costo * MargenDeGanancia;
        }

        public void CalcularIVA()
        {
            CalcularNeto();
            IVA = NetoGravado * PorcentajeDeIva;
        }

        public void CalcularPrecioVenta()
        {
            CalcularNeto();
            CalcularIVA();
            PrecioDeVenta = NetoGravado + IVA;
        }

        public void ActualizarProducto(string descripcion, Marca marca,
            double costo, double porcentajeIVA, double margenDeGanancia)
        {
            Descripcion = descripcion;
            Marca = marca;
            Costo = costo;
            PorcentajeDeIva = porcentajeIVA;
            MargenDeGanancia = margenDeGanancia;
            CalcularNeto();
            CalcularIVA();
            CalcularPrecioVenta();
        }
    }
}
