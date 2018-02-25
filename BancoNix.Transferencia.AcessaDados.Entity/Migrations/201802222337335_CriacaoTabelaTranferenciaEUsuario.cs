namespace BancoNix.TransferenciaAPI.AcessaDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaTranferenciaEUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transferencias",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        usuario_id = c.Int(nullable: false),
                        pagador_nome = c.String(),
                        pagador_banco = c.String(),
                        pagador_agencia = c.String(),
                        pagador_conta = c.String(),
                        beneficiario_nome = c.String(),
                        beneficiario_agencia = c.String(),
                        beneficiario_conta = c.String(),
                        valor = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cnpj = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Transferencias");
        }
    }
}
