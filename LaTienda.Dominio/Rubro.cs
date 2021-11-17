using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Rubro
    {
        public int RubroID { get; set; }
        public string Descripcion { get; set; }
        public List<Producto> ListaProductos { get; set; }

        public void AgregarProducto(Producto producto)
        {
            ListaProductos.Add(producto);
        }
    }
}
