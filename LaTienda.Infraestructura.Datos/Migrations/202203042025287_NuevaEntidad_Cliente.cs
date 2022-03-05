namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaEntidad_Cliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        TipoDocumento = c.Int(nullable: false),
                        NroDocumento = c.Long(nullable: false),
                        RazonSocial = c.String(),
                        Domicilio = c.String(),
                        CondicionTributaria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
