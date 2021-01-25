using System;

namespace CadastroFuncionario.Models
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdimissao { get; set; }
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }

        public const int TamanhoMaximoCargo = 100;
    }
}