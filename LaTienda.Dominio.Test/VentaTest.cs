using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTienda.Dominio.Test
{
    [TestClass]
    public class VentaTest
    {
        private Vendedor _vendedor;
        private Color _colorRojo;
        private Color _colorAzul;
        private Talle _talleXS;
        private Talle _talleS;
        private Marca _marcaZ;
        private Rubro _rubro;
        private double _costo;
        private double _tasaInteres;
        private double _margenGanancia;
        private Producto _producto;

        [TestInitialize]
        public void Setup()
        {
            _vendedor = new Vendedor(1, 123, "vendedor test");
            _colorRojo = new Color(1, "rojo");
            _colorAzul = new Color(2, "azul");
            _talleXS = new Talle(1, "XS");
            _talleS = new Talle(2, "S");
            _marcaZ = new Marca(1, "Zeta");
            _rubro = new Rubro(10, "rubro1");
            _costo = 100;
            _tasaInteres = 0.1;
            _margenGanancia = 0.3;
            // se crea una instancia de producto
            _producto = new Producto(
                100,
                "producto",
                _costo,
                _tasaInteres,
                _margenGanancia,
                _marcaZ,
                _rubro);
        }

        [TestMethod]
        public void AgregarProductoVentaTest()
        {
            var venta = new Venta(_vendedor);
            venta.AgregarProducto(_producto, _colorRojo, _talleXS, 3);
            venta.AgregarProducto(_producto, _colorAzul, _talleS, 4);

            var cantidadLineaVentaEsperada = 2;

            Assert.AreEqual(cantidadLineaVentaEsperada, venta.DetalleVenta.Count);
        }

        [TestMethod]
        public void TotalVentaTest()
        {
            var venta = new Venta(_vendedor);
            venta.AgregarProducto(_producto, _colorRojo, _talleXS, 3);
            venta.AgregarProducto(_producto, _colorAzul, _talleS, 4);

            var totalEsperado = _producto.PrecioDeVenta * 3 + _producto.PrecioDeVenta * 4;

            Assert.AreEqual(totalEsperado, venta.Total);
        }

        [TestMethod]
        public void QuitarProductoTest()
        {
            var venta = new Venta(_vendedor);
            venta.AgregarProducto(_producto, _colorRojo, _talleXS, 3);
            venta.AgregarProducto(_producto, _colorAzul, _talleS, 4);
            venta.QuitarProducto(_producto, _colorAzul, _talleS);

            var cantidadLineaVentaEsperada = 1;

            Assert.AreEqual(cantidadLineaVentaEsperada, venta.DetalleVenta.Count);

        }
    }
}
