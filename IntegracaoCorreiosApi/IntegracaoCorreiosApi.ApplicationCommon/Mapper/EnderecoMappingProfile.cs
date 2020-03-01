using AutoMapper;
using IntegracaoCorreiosApi.Domain;
using WSCorreios;

namespace IntegracaoCorreiosApi.ApplicationCommon.Mapper
{
    public class EnderecoMappingProfile : Profile
    {
        public EnderecoMappingProfile()
        {
            CreateMap<enderecoERP, EnderecoPessoa>()
                    .ForMember(dest => dest.Endereco, m => m.MapFrom(src => src.end));
        }
    }
}
