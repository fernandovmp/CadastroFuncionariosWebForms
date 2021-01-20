namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CricaoDasEntides : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DadosFuncionario", "Documento", c => c.String(nullable: false, maxLength: 300));
            DropColumn("dbo.DadosFuncionario", "EnderecoID");
            DropColumn("dbo.DadosFuncionario", "FuncaoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DadosFuncionario", "FuncaoID", c => c.Int(nullable: false));
            AddColumn("dbo.DadosFuncionario", "EnderecoID", c => c.Int(nullable: false));
            DropColumn("dbo.DadosFuncionario", "Documento");
        }
    }
}
