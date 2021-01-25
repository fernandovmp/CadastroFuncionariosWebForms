using CadastroFuncionario.Models;
using System.Data.Entity.ModelConfiguration;

namespace CadastroFuncionario.Data.Mapeamento
{
    public class MapeamentoFuncionario : IMapeamento<Funcionario>
    {
        public void Configurar(EntityTypeConfiguration<Funcionario> entityConfiguration)
        {
            entityConfiguration
                .ToTable("DadosFuncionario")
                .HasKey(entity => entity.Id);
            entityConfiguration
                .Property(entity => entity.Nome).IsRequired().HasMaxLength(Funcionario.TamanhoMaximoNome);
            entityConfiguration
                 .Property(entity => entity.Rg).IsRequired().HasMaxLength(Funcionario.TamanhoMaximoRg);
            entityConfiguration
                .Property(entity => entity.OrgaoEmissor).IsRequired().HasMaxLength(Funcionario.TamanhoMaximoOrgaoEmissor);
            entityConfiguration
                .Property(entity => entity.Sexo).IsRequired().HasMaxLength(Funcionario.TamanhMaximoSexo);
            entityConfiguration
                 .Property(entity => entity.Cpf).IsRequired();
            entityConfiguration
                .Property(entity => entity.Telefone).IsRequired();
            entityConfiguration
                .Property(entity => entity.Ctps).IsRequired().HasMaxLength(Funcionario.TamanhoMaximoCtps);
            entityConfiguration
                .Property(entity => entity.Documento).IsRequired().HasMaxLength(Funcionario.TamanhoMaximoDocumento);
            entityConfiguration
                .Property(entity => entity.DataNascimento).IsRequired();
            entityConfiguration
                .HasRequired(entity => entity.Funcao)
                .WithRequiredPrincipal();
            entityConfiguration
                .HasRequired(entity => entity.Endereco)
                .WithRequiredPrincipal();
        }
    }
}