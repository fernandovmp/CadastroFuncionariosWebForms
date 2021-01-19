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
            modelBuilder.Entity<Funcionario>()
                .ToTable("DadosFuncionario");
            modelBuilder.Entity<Funcionario>()
                .HasRequired(entity => entity.Funcao)
                .WithRequiredPrincipal();
            modelBuilder.Entity<Funcionario>()
                .HasRequired(entity => entity.Endereco)
                .WithRequiredPrincipal();
            modelBuilder.Entity<Endereco>().ToTable("EnderecoFuncionario");
            modelBuilder.Entity<Funcao>().ToTable("FuncaoFuncionario");
            base.OnModelCreating(modelBuilder);
        }
    }
}