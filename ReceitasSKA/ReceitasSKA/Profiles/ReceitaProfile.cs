using AutoMapper;
using ReceitasSKA.Data.Dtos.ReceitaDTO;
using ReceitasSKA.Models;

namespace ReceitasSKA.Profiles
{
    public class ReceitaProfile : Profile
    {
        public ReceitaProfile()
        {
            //Caso 1:1
            CreateMap<CreateReceitaDto, Receita>();
            CreateMap<Receita, ReadReceitaDto>();
            CreateMap<UpdateReceitaDto, Receita>();
                //Caso 1:N
                //.ForMember(receita => receita.AssociacaoReceita, opts => opts
                //.MapFrom(receita => receita.AssociacaoReceita.Select
                //(ar => new { ar.Id, ar.CodigoProduto, ar.Receita, ar.ReceitaId} )));
        }
    }
}
