using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using ReceitasSKA.Data;
using ReceitasSKA.Data.Dtos.AssociacaoDTO;
using ReceitasSKA.Data.Dtos.ReceitaDTO;
using ReceitasSKA.Models;

namespace ReceitasSKA.Services
{
    public class AssociacaoReceitaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public AssociacaoReceitaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadAssociacaoReceitaDto AdicionarAssociacaoReceita([FromBody] CreateAssociacaoReceitaDto AssociacaoReceita_Dto)
        {
            AssociacaoReceita Associacao_receita = _mapper.Map<AssociacaoReceita>(AssociacaoReceita_Dto);

            _context.AssociacaoReceita.Add(Associacao_receita);
            _context.SaveChanges();
            return _mapper.Map<ReadAssociacaoReceitaDto>(Associacao_receita);
        }

        public IEnumerable<AssociacaoReceita> ConsultarAssociacaoReceita()
        {
            return _context.AssociacaoReceita;
        }

        public ReadAssociacaoReceitaDto ConsultarAssociacaoReceitaPorID(int id)
        {
            AssociacaoReceita Associacao_receita = _context.AssociacaoReceita.FirstOrDefault(Associacao_receita => Associacao_receita.Id == id);
            if (Associacao_receita != null)
            {
                ReadAssociacaoReceitaDto AssociacaoReceita_Dto = _mapper.Map<ReadAssociacaoReceitaDto>(Associacao_receita);

                return AssociacaoReceita_Dto;
            }
            return null;
        }

        public Result AtualizarAssociacaoReceita(int id, UpdateAssociacaoReceitaDto associacaoReceita_Dto)
        {
            AssociacaoReceita Associacao_receita = _context.AssociacaoReceita.FirstOrDefault(Associacao_receita => Associacao_receita.Id == id);
            if (Associacao_receita == null)
            {
                return Result.Fail("Associação de receita não encontrada!");
            }
            _mapper.Map(associacaoReceita_Dto, Associacao_receita);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletearAssociacaoReceita(int id)
        {
            AssociacaoReceita Associacao_receita = _context.AssociacaoReceita.FirstOrDefault(Associacao_receita => Associacao_receita.Id == id);
            if (Associacao_receita == null)
            {
                return Result.Fail("Associação de receita não encontrada!");
            }
            _context.Remove(Associacao_receita);
            _context.SaveChanges();
            return Result.Ok();
        }


    }
}
