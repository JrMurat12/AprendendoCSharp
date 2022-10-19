using ReceitasSKA.Data.Dtos.AssociacaoDTO;
using ReceitasSKA.Data.Dtos.ReceitaDTO;
using ReceitasSKA.Models;
using AutoMapper;

namespace ReceitasSKA.Profiles
{
    public class AssociacaoReceitaProfile : Profile
    {
        public AssociacaoReceitaProfile()
        {
            CreateMap<CreateAssociacaoReceitaDto, AssociacaoReceita>();
            CreateMap<AssociacaoReceita, ReadAssociacaoReceitaDto>();
            CreateMap<UpdateAssociacaoReceitaDto, AssociacaoReceita>();
        }
    }
}
