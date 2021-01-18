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
        [Required, StringLength(TamanhoMaximoRua)]
        public string Rua { get; set; }
        [Required]
        public long Cep { get; set; }
        public int? Numero { get; set; }
        [Required, StringLength(TamanhoMaximoBairro)]
        public string Bairro { get; set; }
        [StringLength(TamanhoMaximoComplemento)]
        public string Complemento { get; set; }
        [Required, StringLength(TamanhoMaximoCidade)]
        public string Cidade { get; set; }
        [Required, StringLength(TamanhoMaximoEstado)]
        public string Estado { get; set; }
        [Required]
        public long Telefone { get; set; }
        [Required, StringLength(TamanhoMaximoCargo)]
        public string Cargo { get; set; }
        [Required]
        public DateTime DataAdimissao { get; set; }
        [Required, StringLength(TamanhoMaximoCtps)]
        public string Ctps { get; set; }

        public const int TamanhoMaximoOrgaoEmissor = 100;
        public const int TamanhoMaximoRua = 100;
        public const int TamanhoMaximoBairro = 100;
        public const int TamanhoMaximoComplemento = 20;
        public const int TamanhoMaximoCidade = 100;
        public const int TamanhoMaximoEstado = 2;
        public const int TamanhoMaximoCargo = 100;
        public const int TamanhoMaximoCtps= 15;
    }
}