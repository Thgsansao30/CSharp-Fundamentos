namespace CSharpFundamentos.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaJuridica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaJuridicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        NomeCompleto = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaJuridicas");
        }
    }
}
