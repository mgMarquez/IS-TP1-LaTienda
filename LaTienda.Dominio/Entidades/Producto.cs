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
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PorcentajeDeIva { get; set; }
        public double MargenDeGanancia { get; set; }

        public int MarcaID { get; set; }
        public virtual Marca Marca { get; set; }
        public int RubroID { get; set; }
        public virtual Rubro Rubro { get; set; }
        public List<Stock> DetalleDeStock { get; private set; }

        public double NetoGravado => Costo + Costo * MargenDeGanancia;
        public double IVA => NetoGravado * PorcentajeDeIva;
        public double PrecioDeVenta => NetoGravado + IVA;

        public Producto() { }

        public Producto(int codigo, string descripcion, double costo, double porcentajeIVA, 
            double margenDeGanancia, Marca marca, Rubro rubro)
        {
            Codigo = codigo;
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
