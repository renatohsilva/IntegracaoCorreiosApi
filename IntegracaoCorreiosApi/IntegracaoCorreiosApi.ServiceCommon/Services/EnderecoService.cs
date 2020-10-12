using Flurl.Http;
using Flurl.Http.Configuration;
using IntegracaoCorreiosApi.Domain;
using IntegracaoCorreiosApi.ServiceCommon.Interfaces;
using System;
using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IFlurlClient flurlClient;

        public EnderecoService(IFlurlClientFactory flurlClientFactory)
        {
            flurlClient = flurlClientFactory.Get("https://viacep.com.br/ws");
        }

        public async Task<EnderecoPessoa> BuscarEndereco(string cep)
        {
            try
            {
                var endereco = await flurlClient.Request(cep, "json").GetJsonAsync<EnderecoPessoa>();
                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar a pesquisa de CEPs", ex);
            }
        }
    }
}
