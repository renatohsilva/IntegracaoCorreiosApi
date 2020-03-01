using IntegracaoCorreiosApi.Domain;
using IntegracaoCorreiosApi.ServiceCommon.Interfaces;
using System;
using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Services
{
    public class EnderecoService : IEnderecoService
    {
        public async Task<WSCorreios.consultaCEPResponse> BuscarEndereco(string cep)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                return await ws.consultaCEPAsync(cep);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar a pesquisa de CEPs", ex);
            }
        }
    }
}
