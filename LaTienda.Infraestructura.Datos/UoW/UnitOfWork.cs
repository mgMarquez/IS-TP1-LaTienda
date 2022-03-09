using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTienda.Dominio;

namespace LaTienda.Infraestructura.Datos
{
    public class UnitOfWork : IUnitOfWork
    {
        private TiendaContext _context = new TiendaContext();
        private IGenericRepository<Producto> _productoRepository;
        private IGenericRepository<Marca> _marcaRepository;
        private IGenericRepository<Rubro> _rubroRepository;
        private IGenericRepository<Stock> _stockRepository;
        private IGenericRepository<Cliente> _clienteRepository;
        private IGenericRepository<Comprobante> _comprobanteRepository;
        private IGenericRepository<Talle> _talleRepository;
        private IGenericRepository<Color> _colorRepository;


        public IGenericRepository<Producto> ProductoRepository
        {
            get
            {
                if (_productoRepository == null)
                {
                    _productoRepository = new Repository<Producto>(_context);
                }
                return _productoRepository;
            }
        }

        public IGenericRepository<Marca> MarcaRepository
        {
            get
            {
                if (_marcaRepository == null)
                {
                    _marcaRepository = new Repository<Marca>(_context);
                }
                return _marcaRepository;
            }
        }

        public IGenericRepository<Rubro> RubroRepository
        {
            get
            {
                if (_rubroRepository == null)
                {
                    _rubroRepository = new Repository<Rubro>(_context);
                }
                return _rubroRepository;
            }
        }

        public IGenericRepository<Stock> StockRepository
        {
            get
            {
                if (_stockRepository == null)
                {
                    _stockRepository = new Repository<Stock>(_context);
                }
                return _stockRepository;
            }
        }

        public IGenericRepository<Cliente> ClienteRepository
        {
            get
            {
                if (_clienteRepository == null)
                {
                    _clienteRepository = new Repository<Cliente>(_context);
                }
                return _clienteRepository;
            }
        }

        public IGenericRepository<Comprobante> ComprobanteRepository
        {
            get
            {
                return _comprobanteRepository = _comprobanteRepository ?? new Repository<Comprobante>(_context);
            }
        }

        public IGenericRepository<Talle> TalleRepository
        {
            get
            {
                return _talleRepository = _talleRepository ?? new Repository<Talle>(_context);
            }
        }

        public IGenericRepository<Color> ColorRepository
        {
            get
            {
                return _colorRepository = _colorRepository ?? new Repository<Color>(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
