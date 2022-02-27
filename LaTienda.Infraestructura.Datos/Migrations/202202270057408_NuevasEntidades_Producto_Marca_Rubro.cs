namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevasEntidades_Producto_Marca_Rubro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.MarcaID);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Costo = c.Double(nullable: false),
                        PorcentajeDeIva = c.Double(nullable: false),
                        MargenDeGanancia = c.Double(nullable: false),
                        Marca_MarcaID = c.Int(),
                        Rubro_RubroID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductoID)
                .ForeignKey("dbo.Marcas", t => t.Marca_MarcaID)
                .ForeignKey("dbo.Rubros", t => t.Rubro_RubroID)
                .Index(t => t.Marca_MarcaID)
                .Index(t => t.Rubro_RubroID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockID = c.Int(nullable: false, identity: true),
                        CantidadEnStock = c.Int(nullable: false),
                        Color_ColorID = c.Int(),
                        Talle_TalleID = c.Int(),
                        Producto_ProductoID = c.Int(),
                    })
                .PrimaryKey(t => t.StockID)
                .ForeignKey("dbo.Colors", t => t.Color_ColorID)
                .ForeignKey("dbo.Talles", t => t.Talle_TalleID)
                .ForeignKey("dbo.Productos", t => t.Producto_ProductoID)
                .Index(t => t.Color_ColorID)
                .Index(t => t.Talle_TalleID)
                .Index(t => t.Producto_ProductoID);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ColorID);
            
            CreateTable(
                "dbo.Talles",
                c => new
                    {
                        TalleID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TalleID);
            
            CreateTable(
                "dbo.Rubros",
                c => new
                    {
                        RubroID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.RubroID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "Rubro_RubroID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "Marca_MarcaID", "dbo.Marcas");
            DropForeignKey("dbo.Stocks", "Producto_ProductoID", "dbo.Productos");
            DropForeignKey("dbo.Stocks", "Talle_TalleID", "dbo.Talles");
            DropForeignKey("dbo.Stocks", "Color_ColorID", "dbo.Colors");
            DropIndex("dbo.Stocks", new[] { "Producto_ProductoID" });
            DropIndex("dbo.Stocks", new[] { "Talle_TalleID" });
            DropIndex("dbo.Stocks", new[] { "Color_ColorID" });
            DropIndex("dbo.Productos", new[] { "Rubro_RubroID" });
            DropIndex("dbo.Productos", new[] { "Marca_MarcaID" });
            DropTable("dbo.Rubros");
            DropTable("dbo.Talles");
            DropTable("dbo.Colors");
            DropTable("dbo.Stocks");
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
        }
    }
}
