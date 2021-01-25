using System;

namespace CadastroFuncionario.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string OrgaoEmissor { get; set; }
        public long Telefone { get; set; }
        public string Ctps { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public Funcao Funcao { get; set; }
        public const int TamanhoMaximoNome = 100;
        public const int TamanhoMaximoRg = 15;
        public const int TamanhoMaximoOrgaoEmissor = 6;
        public const int TamanhoMaximoCtps = 15;
        public const int TamanhMaximoSexo = 10;
        public const int TamanhoMaximoDocumento = 300;
    }
}