using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroFuncionario.Models
{
    public class Funcionario
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public long Cpf { get; set; }
        [Required]
        public long Rg { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required, StringLength(10)]
        public string Sexo { get; set; }
        [Required, StringLength(TamanhoMaximoOrgaoEmissor)]
        public string OrgaoEmissor { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required, StringLength(TamanhoMaximoCtps)]
        public string Ctps { get; set; }
        public int EnderecoID { get; set; }
        public Endereco Endereco { get; set; }
        public int FuncaoID { get; set; }
        public Funcao Funcao { get; set; }

        public const int TamanhoMaximoOrgaoEmissor = 100;
        public const int TamanhoMaximoCtps = 15;
    }
}