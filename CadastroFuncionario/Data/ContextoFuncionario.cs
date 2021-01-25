using CadastroFuncionario.Data.Mapeamento;
using CadastroFuncionario.Models;
using System.Data.Entity;

namespace CadastroFuncionario.Data
{
    public class ContextoFuncionario : DbContext
    {
        public ContextoFuncionario() : this(nameOrConnectionString: "CadastroFuncionario") { }
        public ContextoFuncionario(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new MapeamentoFuncionario().Configurar(modelBuilder.Entity<Funcionario>());
            new MapeamentoEndereco().Configurar(modelBuilder.Entity<Endereco>());
            new MapeamentoFuncao().Configurar(modelBuilder.Entity<Funcao>());
            base.OnModelCreating(modelBuilder);
        }
    }
}