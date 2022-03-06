namespace LaTienda.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaEntidadComprobante : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comprobantes",
                c => new
                    {
                        ComprobanteID = c.Int(nullable: false, identity: true),
                        NumeroDeComprobante = c.Int(nullable: false),
                        DocumentoTipoCliente = c.Int(nullable: false),
                        NumeroDocumentoCliente = c.Long(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        ImporteTotal = c.Double(nullable: false),
                        ImpTotConc = c.Double(nullable: false),
                        ImpNeto = c.Double(nullable: false),
                        ImpOpEx = c.Double(nullable: false),
                        ImpIVA = c.Double(nullable: false),
                        ImpTrib = c.Double(nullable: false),
                        CAE = c.String(),
                        NumeroPDV = c.Int(nullable: false),
                        HabilitacionPDV = c.Guid(nullable: false),
                        TipoComprobante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComprobanteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comprobantes");
        }
    }
}
