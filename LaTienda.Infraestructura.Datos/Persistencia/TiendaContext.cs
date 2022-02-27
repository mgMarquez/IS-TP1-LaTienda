﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using LaTienda.Dominio;

namespace LaTienda.Infraestructura.Datos
{
    public class TiendaContext : DbContext
    {
        public TiendaContext() : base("name=TiendaConnectionString") { }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Rubro> Rubros { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Marca>().ToTable("Marcas");
            modelBuilder.Entity<Rubro>().ToTable("Rubros");
            modelBuilder.Entity<Stock>().ToTable("Stocks");


            base.OnModelCreating(modelBuilder);
        }
    }
}
