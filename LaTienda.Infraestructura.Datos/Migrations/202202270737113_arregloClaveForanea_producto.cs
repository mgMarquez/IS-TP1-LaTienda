namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arregloClaveForanea_producto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Marca_MarcaID", "dbo.Marcas");
            DropForeignKey("dbo.Productos", "Rubro_RubroID", "dbo.Rubros");
            DropIndex("dbo.Productos", new[] { "Marca_MarcaID" });
            DropIndex("dbo.Productos", new[] { "Rubro_RubroID" });
            RenameColumn(table: "dbo.Productos", name: "Marca_MarcaID", newName: "MarcaID");
            RenameColumn(table: "dbo.Productos", name: "Rubro_RubroID", newName: "RubroID");
            AlterColumn("dbo.Productos", "MarcaID", c => c.Int(nullable: false));
            AlterColumn("dbo.Productos", "RubroID", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "MarcaID");
            CreateIndex("dbo.Productos", "RubroID");
            AddForeignKey("dbo.Productos", "MarcaID", "dbo.Marcas", "MarcaID", cascadeDelete: true);
            AddForeignKey("dbo.Productos", "RubroID", "dbo.Rubros", "RubroID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "RubroID", "dbo.Rubros");
            DropForeignKey("dbo.Productos", "MarcaID", "dbo.Marcas");
            DropIndex("dbo.Productos", new[] { "RubroID" });
            DropIndex("dbo.Productos", new[] { "MarcaID" });
            AlterColumn("dbo.Productos", "RubroID", c => c.Int());
            AlterColumn("dbo.Productos", "MarcaID", c => c.Int());
            RenameColumn(table: "dbo.Productos", name: "RubroID", newName: "Rubro_RubroID");
            RenameColumn(table: "dbo.Productos", name: "MarcaID", newName: "Marca_MarcaID");
            CreateIndex("dbo.Productos", "Rubro_RubroID");
            CreateIndex("dbo.Productos", "Marca_MarcaID");
            AddForeignKey("dbo.Productos", "Rubro_RubroID", "dbo.Rubros", "RubroID");
            AddForeignKey("dbo.Productos", "Marca_MarcaID", "dbo.Marcas", "MarcaID");
        }
    }
}
