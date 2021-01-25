using System.Data.Entity.ModelConfiguration;

namespace CadastroFuncionario.Data.Mapeamento
{
    public interface IMapeamento<T> where T : class
    {
        void Configurar(EntityTypeConfiguration<T> entityConfiguration);
    }
}