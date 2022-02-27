namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaEntidadStocks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "Producto_ProductoID", "dbo.Productos");
            DropForeignKey("dbo.Stocks", "Color_ColorID", "dbo.Colors");
            DropForeignKey("dbo.Stocks", "Talle_TalleID", "dbo.Talles");
            DropIndex("dbo.Stocks", new[] { "Color_ColorID" });
            DropIndex("dbo.Stocks", new[] { "Talle_TalleID" });
            DropIndex("dbo.Stocks", new[] { "Producto_ProductoID" });
            RenameColumn(table: "dbo.Stocks", name: "Producto_ProductoID", newName: "ProductoID");
            RenameColumn(table: "dbo.Stocks", name: "Color_ColorID", newName: "ColorID");
            RenameColumn(table: "dbo.Stocks", name: "Talle_TalleID", newName: "TalleID");
            AlterColumn("dbo.Stocks", "ColorID", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "TalleID", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "ProductoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Stocks", "TalleID");
            CreateIndex("dbo.Stocks", "ColorID");
            CreateIndex("dbo.Stocks", "ProductoID");
            AddForeignKey("dbo.Stocks", "ProductoID", "dbo.Productos", "ProductoID", cascadeDelete: true);
            AddForeignKey("dbo.Stocks", "ColorID", "dbo.Colors", "ColorID", cascadeDelete: true);
            AddForeignKey("dbo.Stocks", "TalleID", "dbo.Talles", "TalleID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "TalleID", "dbo.Talles");
            DropForeignKey("dbo.Stocks", "ColorID", "dbo.Colors");
            DropForeignKey("dbo.Stocks", "ProductoID", "dbo.Productos");
            DropIndex("dbo.Stocks", new[] { "ProductoID" });
            DropIndex("dbo.Stocks", new[] { "ColorID" });
            DropIndex("dbo.Stocks", new[] { "TalleID" });
            AlterColumn("dbo.Stocks", "ProductoID", c => c.Int());
            AlterColumn("dbo.Stocks", "TalleID", c => c.Int());
            AlterColumn("dbo.Stocks", "ColorID", c => c.Int());
            RenameColumn(table: "dbo.Stocks", name: "TalleID", newName: "Talle_TalleID");
            RenameColumn(table: "dbo.Stocks", name: "ColorID", newName: "Color_ColorID");
            RenameColumn(table: "dbo.Stocks", name: "ProductoID", newName: "Producto_ProductoID");
            CreateIndex("dbo.Stocks", "Producto_ProductoID");
            CreateIndex("dbo.Stocks", "Talle_TalleID");
            CreateIndex("dbo.Stocks", "Color_ColorID");
            AddForeignKey("dbo.Stocks", "Talle_TalleID", "dbo.Talles", "TalleID");
            AddForeignKey("dbo.Stocks", "Color_ColorID", "dbo.Colors", "ColorID");
            AddForeignKey("dbo.Stocks", "Producto_ProductoID", "dbo.Productos", "ProductoID");
        }
    }
}
