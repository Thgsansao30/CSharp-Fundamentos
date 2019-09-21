namespace CSharpFundamentos.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaFisica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        UsuarioId = c.Int(nullable: false),
                        NomeCompleto = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaFisicas", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.PessoaFisicas", new[] { "UsuarioId" });
            DropTable("dbo.PessoaFisicas");
        }
    }
}
