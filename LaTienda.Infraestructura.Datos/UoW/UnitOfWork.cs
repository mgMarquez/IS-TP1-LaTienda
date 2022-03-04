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
        private readonly TiendaContext _context;
        private IGenericRepository<Producto> _productoRepository;
        private IGenericRepository<Marca> _marcaRepository;
        private IGenericRepository<Rubro> _rubroRepository;
        private IGenericRepository<Stock> _stockRepository;
        private IGenericRepository<Cliente> _clienteRepository;

        public UnitOfWork(TiendaContext context)
        {
            _context = context;
        }

        public IGenericRepository<Producto> ProductoRepository
        {
            get
            {
                if (_productoRepository == null)
                {
                    _productoRepository = new GenericRepository<Producto>(_context);
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
                    _marcaRepository = new GenericRepository<Marca>(_context);
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
                    _rubroRepository = new GenericRepository<Rubro>(_context);
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
                    _stockRepository = new GenericRepository<Stock>(_context);
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
                    _clienteRepository = new GenericRepository<Cliente>(_context);
                }
                return _clienteRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
