using Microsoft.VisualStudio.TestTools.UnitTesting;
using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio.Tests
{
    [TestClass]
    public class PruebasUnitariasTest
    {
        private Color _colorRojo;
        private Talle _talleXS;
        private Marca _marcaZ;
        private Rubro _rubro;
        private double _costo;
        private double _tasaInteres;
        private double _margenGanancia;
        private Producto _producto;

        [TestInitialize]
        public void Setup()
        {
            _colorRojo = new Color(1, "rojo");
            _talleXS = new Talle(1, "XS");
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
        public void CalcularNetoGravadoTest()
        {
            // Arrange
            // la instancia de producto se crea en Setup
            double resultadoEsperado = 130;
            // Act
            //Costo + Costo * MargenDeGanancia
            // Assert
            Assert.AreEqual(resultadoEsperado, _producto.NetoGravado, 0.1);
        }

        [TestMethod]
        public void CalcularIVATest()
        {
            // Arrange
            // la instancia de producto se crea en Setup
            double resultadoEsperado = 13;
            // Act
            //IVA = NetoGravado * PorcentajeDeIva
            // Assert
            Assert.AreEqual(resultadoEsperado, _producto.IVA, 0.1);
        }

        [TestMethod]
        public void CalcularPrecioVentaTest()
        {
            // Arrange
            // la instancia de producto se crea en Setup
            double resultadoEsperado = 143;
            // Act
            //IVA = NetoGravado * PorcentajeDeIva
            // Assert
            Assert.AreEqual(resultadoEsperado, _producto.PrecioDeVenta, 0.1);
        }

        // clase LineaDeVenta
        [TestMethod]
        public void ObtenerSubTotalTest()
        {
            // Arrange
            // la instancia de producto se crea en Setup
            int cantidadProductos = 10;
            LineaDeVenta lineaDeVenta = new LineaDeVenta(
                _producto, 
                _colorRojo, 
                _talleXS, 
                cantidadProductos);
            double resultadoEsperado = 1430;//SubTotal = PrecioDeVenta * Cantidad
            // Act
            double resultadoReal = lineaDeVenta.ObtenerSubTotal();
            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoReal, 0.1);
        }

        // clase Sesion
        [TestMethod]
        public void SesionEmpleadoTest()
        {
            // Arrange
            int empleadoID = 10;
            int legajo = 999;
            string nombre = "EmpleadoTest";
            Empleado empleado = new Empleado(
                empleadoID, 
                legajo, 
                nombre);
            // Act
            Sesion.AsignarEmpleado(empleado);
            // Assert
            Assert.AreEqual(empleado, Sesion.Empleado);
        }
    }
}