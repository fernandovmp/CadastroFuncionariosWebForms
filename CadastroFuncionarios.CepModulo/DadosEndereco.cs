using Newtonsoft.Json;

namespace CadastroFuncionarios.CepModulo
{
    public class DadosEndereco
    {
        [JsonProperty("neighborhood")]
        public string Bairro { get; set; }
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("city")]
        public string Cidade { get; set; }
        [JsonProperty("state")]
        public string Estado { get; set; }
        [JsonProperty("street")]
        public string Rua { get; set; }
    }
}