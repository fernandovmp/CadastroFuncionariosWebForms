using CadastroFuncionario.Models;
using System.Data.Entity.ModelConfiguration;

namespace CadastroFuncionario.Data.Mapeamento
{
    public class MapeamentoEndereco : IMapeamento<Endereco>
    {
        public void Configurar(EntityTypeConfiguration<Endereco> entityConfiguration)
        {
            entityConfiguration
                .ToTable("EnderecoFuncionario")
                .HasKey(entity => entity.Id);
            entityConfiguration
                .Property(entity => entity.Rua).IsRequired().HasMaxLength(Endereco.TamanhoMaximoRua);
            entityConfiguration
                .Property(entity => entity.Cidade).IsRequired().HasMaxLength(Endereco.TamanhoMaximoCidade);
            entityConfiguration
                .Property(entity => entity.Estado).IsRequired().HasMaxLength(Endereco.TamanhoMaximoEstado);
            entityConfiguration
                .Property(entity => entity.Bairro).IsRequired().HasMaxLength(Endereco.TamanhoMaximoBairro);
            entityConfiguration
                .Property(entity => entity.Complemento).HasMaxLength(Endereco.TamanhoMaximoComplemento);
            entityConfiguration
                .Property(entity => entity.Numero);
            entityConfiguration
                .Property(entity => entity.Cep).IsRequired();
        }
    }
}