using CadastroFuncionario.Models;
using System.Data.Entity;

namespace CadastroFuncionario.Data
{
    public class ContextoFuncionario : DbContext
    {
        public ContextoFuncionario() : this(nameOrConnectionString: "CadastroFuncionario") { }
        public ContextoFuncionario(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}