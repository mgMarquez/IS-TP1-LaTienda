using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorGestionarStock
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGestionarStockVista _vista;

        public ControladorGestionarStock(IUnitOfWork unitOfWork, IGestionarStockVista vista)
        {
            _unitOfWork = unitOfWork;
            _vista = vista;
        }

        internal void BuscarStocks(string filtro)
        {
            var filtroMinusculas = filtro.ToLower();
            List<Stock> stocks;
            if (string.IsNullOrEmpty(filtro))
            {
                stocks = _unitOfWork.StockRepository.GetAll().ToList();
            }
            else
            {
                stocks = _unitOfWork.StockRepository
                    .Find(s => s.StockID.ToString().Contains(filtroMinusculas) ||
                        s.Talle.Descripcion.ToLower().Contains(filtroMinusculas) ||
                        s.Color.Descripcion.ToLower().Contains(filtroMinusculas)).ToList();
            }
            _vista.MostrarListaStocks(stocks);
        }

        public List<Producto> BuscarProductosDisponibles()
        {
            return _unitOfWork.ProductoRepository.GetAll().ToList();
        }

        public List<Color> BuscarColoresDisponibles()
        {
            return _unitOfWork.ColorRepository.GetAll().ToList();
        }

        public List<Talle> BuscarTallesDisponibles()
        {
            return _unitOfWork.TalleRepository.GetAll().ToList();
        }

        public void CrearStock(Stock stockNuevo)
        {
            _unitOfWork.StockRepository.Create(stockNuevo);
            _unitOfWork.Save();
        }

        public void ModificarStock(Stock stockModificado)
        {
            _unitOfWork.StockRepository.Update(stockModificado);
            _unitOfWork.Save();
        }

        public void EliminarStock(Stock stock)
        {
            EliminarStock(stock.StockID);
        }

        public void EliminarStock(int idStock)
        {
            _unitOfWork.StockRepository.Delete(idStock);
            _unitOfWork.Save();
        }
    }
}
