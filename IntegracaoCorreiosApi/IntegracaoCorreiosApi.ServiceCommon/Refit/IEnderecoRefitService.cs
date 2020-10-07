using IntegracaoCorreiosApi.Domain;
using Refit;
using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Refit
{
    public interface IEnderecoRefitService
    {
        [Get("/ws/{cep}/json/")]
        Task<EnderecoPessoa> GetEndereco([Query] string cep);
    }
}
