using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class Funcao
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required, StringLength(TamanhoMaximoCargo)]
        public string Cargo { get; set; }
        [Required]
        public DateTime DataAdimissao { get; set; }
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }

        public const int TamanhoMaximoCargo = 100;
    }
}