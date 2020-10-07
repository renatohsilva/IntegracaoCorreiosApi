using IntegracaoCorreiosApi.Domain;
using IntegracaoCorreiosApi.ServiceCommon.Interfaces;
using IntegracaoCorreiosApi.ServiceCommon.Refit;
using Refit;
using System;
using System.Threading.Tasks;

namespace IntegracaoCorreiosApi.ServiceCommon.Services
{
    public class EnderecoService : IEnderecoService
    {
        public async Task<EnderecoPessoa> BuscarEndereco(string cep)
        {
            try
            {
                var cepClient = RestService.For<IEnderecoRefitService>("https://viacep.com.br");
                var endereco = await cepClient.GetEndereco(cep);
                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar a pesquisa de CEPs", ex);
            }
        }
    }
}
