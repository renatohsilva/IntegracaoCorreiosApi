using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper mapper;

        public EnderecoPessoaController(IEnderecoService enderecoService, IMapper mapper)
        {
            this.enderecoService = enderecoService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<EnderecoPessoa> GetEndereco(string cep)
        {
            try
            {
                var consultaCEP = await enderecoService.BuscarEndereco(cep);
                var endereco = mapper.Map<WSCorreios.enderecoERP, EnderecoPessoa>(consultaCEP.@return);
                return endereco;
            }
            catch 
            {
                return null;
            }
        }
    }
}