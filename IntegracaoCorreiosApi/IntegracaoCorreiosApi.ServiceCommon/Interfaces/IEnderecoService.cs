using IntegracaoCorreiosApi.Domain;
using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Interfaces
{
    public interface IEnderecoService
    {
        public Task<EnderecoPessoa> BuscarEndereco(string cep);
    }
}
