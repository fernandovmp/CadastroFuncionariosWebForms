using CadastroFuncionario.Models;
using System.Data.Entity.ModelConfiguration;

namespace CadastroFuncionario.Data.Mapeamento
{
    public class MapeamentoFuncao : IMapeamento<Funcao>
    {
        public void Configurar(EntityTypeConfiguration<Funcao> entityConfiguration)
        {
            entityConfiguration
                 .ToTable("FuncaoFuncionario")
                 .HasKey(entity => entity.Id);
            entityConfiguration
                .Property(entity => entity.Cargo).IsRequired().HasMaxLength(Funcao.TamanhoMaximoCargo);
            entityConfiguration
                .Property(entity => entity.DataAdimissao).IsRequired();
        }
    }
}