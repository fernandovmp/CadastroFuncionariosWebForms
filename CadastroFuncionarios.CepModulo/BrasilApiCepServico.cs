using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CadastroFuncionarios.CepModulo
{
    public class BrasilApiCepServico : ICepServico
    {
        private const string UrlBase = "https://brasilapi.com.br/api/cep/v1";
        public async Task<DadosEndereco> ObterEndereco(long cep)
        {
            using (var cliente = new HttpClient())
            {
                HttpResponseMessage response = await cliente.GetAsync($"{UrlBase}/{cep}");
                if(response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    DadosEndereco endereco = JsonConvert.DeserializeObject<DadosEndereco>(json);
                    return endereco;
                }
                return null;
            }
        }
    }
}
