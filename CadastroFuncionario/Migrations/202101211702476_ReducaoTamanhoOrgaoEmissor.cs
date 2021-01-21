namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReducaoTamanhoOrgaoEmissor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DadosFuncionario", "OrgaoEmissor", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DadosFuncionario", "OrgaoEmissor", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
