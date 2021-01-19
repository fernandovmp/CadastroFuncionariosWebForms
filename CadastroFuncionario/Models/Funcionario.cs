using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroFuncionario.Models
{
    public class Funcionario
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required, StringLength(TamanhoMaximoNome)]
        public string Nome { get; set; }
        [Required]
        public long Cpf { get; set; }
        [Required, StringLength(TamanhoMaximoRg)]
        public string Rg { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required, StringLength(TamanhMaximoSexo)]
        public string Sexo { get; set; }
        [Required, StringLength(TamanhoMaximoOrgaoEmissor)]
        public string OrgaoEmissor { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required, StringLength(TamanhoMaximoCtps)]
        public string Ctps { get; set; }
        public Endereco Endereco { get; set; }
        public Funcao Funcao { get; set; }
        public const int TamanhoMaximoNome = 100;
        public const int TamanhoMaximoRg = 15;
        public const int TamanhoMaximoOrgaoEmissor = 100;
        public const int TamanhoMaximoCtps = 15;
        public const int TamanhMaximoSexo = 10;
    }
}