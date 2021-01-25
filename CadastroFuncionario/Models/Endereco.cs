namespace CadastroFuncionario.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public long Cep { get; set; }
        public int? Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
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