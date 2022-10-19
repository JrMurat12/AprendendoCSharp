using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ReceitasSKA.Data;
using ReceitasSKA.Data.Dtos.AssociacaoDTO;
using ReceitasSKA.Data.Dtos.ReceitaDTO;
using ReceitasSKA.Models;
using ReceitasSKA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceitasSKA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssociacaoReceitaController : ControllerBase
    {
        private AssociacaoReceitaService _associacaoreceitaService;

        public AssociacaoReceitaController(AssociacaoReceitaService associacaoreceitaService)
        {
            _associacaoreceitaService = associacaoreceitaService;
    }

        //Método para Inserir uma Associação de Receita
        [HttpPost]
        public IActionResult AdicionarAssociacaoReceita([FromBody] CreateAssociacaoReceitaDto AssociacaoReceita_Dto)
        {
            ReadAssociacaoReceitaDto readDto = _associacaoreceitaService.AdicionarAssociacaoReceita(AssociacaoReceita_Dto);
            
            return CreatedAtAction(nameof(ConsultarAssociacaoReceitaPorID), new { Id = readDto.Id }, readDto);
        }

        //[HttpGet]
        //public IActionResult RecuperarAssociacaoReceita([FromQuery] string lotePadrao)
        //{
        //    List<AssociacaoReceita> Associacao_receita = _context.AssociacaoReceita.ToList();
        //    if(Associacao_receita == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!string.IsNullOrEmpty(lotePadrao))
        //    {
        //        IEnumerable<AssociacaoReceita> query = from associacao_receita in Associacao_receita  
        //                where associacao_receita.AssociacaoReceita.Any(receita =>
        //                receita.Receita.LotePadrao == lotePadrao)
        //                select associacao_receita;

        //        Associacao_receita = query.ToList();
        //    }
        //    List<ReadAssociacaoReceitaDto> readDto = _mapper.Map<List<ReadAssociacaoReceitaDto>>(Associacao_receita);

        //    return Ok(readDto);
        //}

        //Método para Consultar Associação de Receita
        [HttpGet]
        public IEnumerable<AssociacaoReceita> ConsultarAssociacaoReceita()
        {
            return _associacaoreceitaService.ConsultarAssociacaoReceita();
            
        }

        //Método para Consultar uma Associação de Receita específica por ID
        [HttpGet("{id}")]
        public IActionResult ConsultarAssociacaoReceitaPorID(int id)
        {
            ReadAssociacaoReceitaDto readDto = _associacaoreceitaService.ConsultarAssociacaoReceitaPorID(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }
            else
            {
                return NotFound();
            }

            
        }

        //Método para Atualizar uma Associação de Receita específica por ID
        [HttpPut("{id}")]
        public IActionResult AtualizarAssociacaoReceita(int id, [FromBody] UpdateAssociacaoReceitaDto associacaoReceita_Dto)
        {
            Result resultado = _associacaoreceitaService.AtualizarAssociacaoReceita(id, associacaoReceita_Dto);
            if (resultado.IsFailed)
            {
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }

        //Método para Deletar uma Associação de Receita específica por ID
        [HttpDelete("{id}")]
        public IActionResult DeletarAssociacaoReceita(int id)
        {
            Result resultado = _associacaoreceitaService.DeletearAssociacaoReceita(id);
            if (resultado.IsFailed)
            {
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
