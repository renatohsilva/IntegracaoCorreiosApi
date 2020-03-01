using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Interfaces
{
    public interface IEnderecoService
    {
        public Task<WSCorreios.consultaCEPResponse> BuscarEndereco(string cep);
    }
}
