namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnderecoFuncionario",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 100),
                        Cep = c.Long(nullable: false),
                        Numero = c.Int(),
                        Bairro = c.String(nullable: false, maxLength: 100),
                        Complemento = c.String(maxLength: 20),
                        Cidade = c.String(nullable: false, maxLength: 100),
                        Estado = c.String(nullable: false, maxLength: 2),
                        FuncionarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosFuncionario", t => t.Id)
                .ForeignKey("dbo.DadosFuncionario", t => t.FuncionarioID, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.DadosFuncionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Cpf = c.Long(nullable: false),
                        Rg = c.String(nullable: false, maxLength: 15),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 10),
                        OrgaoEmissor = c.String(nullable: false, maxLength: 100),
                        Telefone = c.Long(nullable: false),
                        Ctps = c.String(nullable: false, maxLength: 15),
                        EnderecoID = c.Int(nullable: false),
                        FuncaoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuncaoFuncionario",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cargo = c.String(nullable: false, maxLength: 100),
                        DataAdimissao = c.DateTime(nullable: false),
                        FuncionarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosFuncionario", t => t.FuncionarioID, cascadeDelete: true)
                .ForeignKey("dbo.DadosFuncionario", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.FuncionarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnderecoFuncionario", "FuncionarioID", "dbo.DadosFuncionario");
            DropForeignKey("dbo.FuncaoFuncionario", "Id", "dbo.DadosFuncionario");
            DropForeignKey("dbo.FuncaoFuncionario", "FuncionarioID", "dbo.DadosFuncionario");
            DropForeignKey("dbo.EnderecoFuncionario", "Id", "dbo.DadosFuncionario");
            DropIndex("dbo.FuncaoFuncionario", new[] { "FuncionarioID" });
            DropIndex("dbo.FuncaoFuncionario", new[] { "Id" });
            DropIndex("dbo.EnderecoFuncionario", new[] { "FuncionarioID" });
            DropIndex("dbo.EnderecoFuncionario", new[] { "Id" });
            DropTable("dbo.FuncaoFuncionario");
            DropTable("dbo.DadosFuncionario");
            DropTable("dbo.EnderecoFuncionario");
        }
    }
}
