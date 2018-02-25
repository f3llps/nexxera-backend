namespace BancoNix.TransferenciaAPI.AcessaDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTransferencia : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Transferencias", name: "Beneficiario_Id_id", newName: "Beneficiario_id");
            RenameColumn(table: "dbo.Transferencias", name: "Pagador_Id_id", newName: "Pagador_id");
            RenameIndex(table: "dbo.Transferencias", name: "IX_Beneficiario_Id_id", newName: "IX_Beneficiario_id");
            RenameIndex(table: "dbo.Transferencias", name: "IX_Pagador_Id_id", newName: "IX_Pagador_id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Transferencias", name: "IX_Pagador_id", newName: "IX_Pagador_Id_id");
            RenameIndex(table: "dbo.Transferencias", name: "IX_Beneficiario_id", newName: "IX_Beneficiario_Id_id");
            RenameColumn(table: "dbo.Transferencias", name: "Pagador_id", newName: "Pagador_Id_id");
            RenameColumn(table: "dbo.Transferencias", name: "Beneficiario_id", newName: "Beneficiario_Id_id");
        }
    }
}
