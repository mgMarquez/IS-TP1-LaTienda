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
using Color = LaTienda.Dominio.Color;

namespace LaTienda.Presentador
{
    public partial class StockVista : Form, IStockVista
    {
        private Stock _stock;
        private List<Producto> _productos;
        private List<Talle> _talles;
        private List<Color> _colores;
        public Action<Stock> EventoConfirmar { get; internal set; }

        public StockVista()
        {
            InitializeComponent();
        }


        public void MostrarProductos(List<Producto> productos)
        {
            _productos = productos;
            CbProducto.DataSource = _productos;
        }

        public void MostrarTalles(List<Talle> talles)
        {
            _talles = talles;
            CbTalle.DataSource = _talles;
        }

        public void MostrarColores(List<Color> colores)
        {
            _colores = colores;
            CbColor.DataSource = _colores;
        }

        public void MostrarStock(Stock stock)
        {
            try
            {
                _stock = stock ?? throw new ArgumentNullException();
                BsStock.DataSource = _stock;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            AsignarTalleColorProductoAStock();
            EventoConfirmar?.Invoke(_stock);
            this.Close();
        }

        private void AsignarTalleColorProductoAStock()
        {
            _stock.Producto = CbProducto.SelectedItem as Producto;
            _stock.Talle = CbTalle.SelectedItem as Talle;
            _stock.Color = CbColor.SelectedItem as Color;

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void VistaModificar()
        {
            LabelGestionarStock.Text = "Modificar stock";
            TbStockId.Enabled = false;
        }

        public void VistaCrear()
        {
            LabelGestionarStock.Text = "Crear stock";
        }

        public void VistaEliminar()
        {
            LabelGestionarStock.Text = "¿Desea eliminar el stock?";
            TbStockId.Enabled = false;
            CbProducto.Enabled = false;
            CbColor.Enabled = false;
            CbTalle.Enabled = false;
            TbCantStock.Enabled = false;
        }
    }
}
