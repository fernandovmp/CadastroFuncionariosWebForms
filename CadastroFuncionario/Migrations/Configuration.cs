namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CadastroFuncionario.Data.ContextoFuncionario>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CadastroFuncionario.Data.ContextoFuncionario";
        }

        protected override void Seed(CadastroFuncionario.Data.ContextoFuncionario context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
