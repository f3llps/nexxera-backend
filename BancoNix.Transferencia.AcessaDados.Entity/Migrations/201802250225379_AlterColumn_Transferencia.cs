namespace BancoNix.TransferenciaAPI.AcessaDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterColumn_Transferencia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transferencias", "beneficiario_banco", c => c.String());
            AddColumn("dbo.Transferencias", "tipo", c => c.String());
            AlterColumn("dbo.Transferencias", "valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transferencias", "valor", c => c.String());
            DropColumn("dbo.Transferencias", "tipo");
            DropColumn("dbo.Transferencias", "beneficiario_banco");
        }
    }
}
