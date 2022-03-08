using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTienda.Presentador
{
    public partial class ProductoVista : Form, IProductoVista
    {
        private Producto _producto;
        private List<Marca> _marcas;
        private List<Rubro> _rubros;
        public Action<Producto> EventoConfirmar { get; internal set; }

        public ProductoVista()
        {
            InitializeComponent();
        }


        public void MostrarMarcas(List<Marca> marcas)
        {
            _marcas = marcas;
            CbMarca.DataSource = _marcas;
        }
        
        public void MostrarRubros(List<Rubro> rubros)
        {
            _rubros = rubros;
            CbRubro.DataSource = _rubros;
        }

        public void MostrarProducto(Producto producto)
        {
            try
            {
                _producto = producto ?? throw new ArgumentNullException();
                BsProducto.DataSource = _producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            AsignarMarcaRubroAProducto();
            EventoConfirmar?.Invoke(_producto);
            this.Close();
        }

        private void AsignarMarcaRubroAProducto()
        {
            _producto.Marca = CbMarca.SelectedItem as Marca;
            _producto.Rubro = CbRubro.SelectedItem as Rubro;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void VistaModificar()
        {
            LabelGestionarProducto.Text = "Modificar producto";
            TbCodigo.Enabled = false;
        }

        public void VistaCrear()
        {
            LabelGestionarProducto.Text = "Crear producto";
        }

        public void VistaEliminar()
        {
            LabelGestionarProducto.Text = "¿Desea eliminar el producto?";
            TbCodigo.Enabled = false;
            TbCosto.Enabled = false;
            TbDescripcion.Enabled = false;
            TbPorcentajeGanancias.Enabled = false;
            TbPorcentajeIva.Enabled = false;
            CbMarca.Enabled = false;
            CbRubro.Enabled = false;
        }
    }
}
