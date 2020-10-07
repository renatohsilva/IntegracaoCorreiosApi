using System.Threading.Tasks;
using IntegracaoCorreiosApi.Domain;
using IntegracaoCorreiosApi.ServiceCommon.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoCorreiosApi.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoPessoaController : ControllerBase
    {
        private readonly IEnderecoService enderecoService;

        public EnderecoPessoaController(IEnderecoService enderecoService)
        {
            this.enderecoService = enderecoService;
        }

        [HttpGet]
        public async Task<EnderecoPessoa> GetEndereco(string cep)
        {
            try
            {
                return await enderecoService.BuscarEndereco(cep);
            }
            catch 
            {
                return null;
            }
        }
    }
}