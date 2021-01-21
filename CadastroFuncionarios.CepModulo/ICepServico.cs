using System.Threading.Tasks;

namespace CadastroFuncionarios.CepModulo
{
    public interface ICepServico
    {
        Task<DadosEndereco> ObterEndereco(long cep);
    }
}