using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class Endereco
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
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
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }

        public const int TamanhoMaximoRua = 100;
        public const int TamanhoMaximoBairro = 100;
        public const int TamanhoMaximoComplemento = 20;
        public const int TamanhoMaximoCidade = 100;
        public const int TamanhoMaximoEstado = 2;
    }
}