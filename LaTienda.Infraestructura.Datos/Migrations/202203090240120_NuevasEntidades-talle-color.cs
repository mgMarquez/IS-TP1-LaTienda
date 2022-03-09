namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevasEntidadestallecolor : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Colors", newName: "Colores");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Colores", newName: "Colors");
        }
    }
}
