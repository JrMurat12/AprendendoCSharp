using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ReceitasSKA.Data;
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
    public class ReceitaController : ControllerBase
    {
        private ReceitaService _receitaService;

        public ReceitaController(ReceitaService receitaService)
        {
            _receitaService = receitaService;   
        }

        //Método para Inserir Receita Genérica
        [HttpPost]
        public IActionResult AdicionarReceita([FromBody] CreateReceitaDto receitaDto)
        {
            ReadReceitaDto readDto = _receitaService.AdicionarReceita(receitaDto);

            return Ok(readDto); /*CreatedAtAction(nameof(ConsultarReceitasPorID), new {id = readDto.Id}, readDto);*/
        }

        //Executando Consultas
        //[HttpGet]
        //public IActionResult RecuperarReceita([FromQuery] string? codigoCT = null)
        //{
        //    List<Receita> receitas;
        //    if (codigoCT == null)
        //    {
        //        receitas = _context.Receitas.ToList();
        //    }
        //    else
        //    {
        //        receitas = _context
        //            .Receitas.Where(receita => receita.CodigoCT == codigoCT).ToList();
        //    }


        //    if(receitas != null)
        //    {
        //        List<ReadReceitaDto> readDto = _mapper.Map<List<ReadReceitaDto>>(receitas);
        //        return Ok(readDto);
        //    }
        //    return NotFound();
        //}

        //Método para Consultar Receita Genérica geral
        [HttpGet]
        public IEnumerable<Receita> ConsultarReceita()
        {
            return _receitaService.ConsultarReceita();
        }

        //Método para Consultar Receita Genérica específica por ID
        [HttpGet("{id}")]
        public IActionResult ConsultarReceitasPorID(int id)
        {
            ReadReceitaDto readDto = _receitaService.ConsultarReceitasPorID(id);
            if(readDto != null)
            {
                return Ok(readDto); 
            }
            else
            {
                return NotFound();
            } 
        }

        //Método para Atualizar Receita Genérica específica por ID
        [HttpPut("{id}")]
        public IActionResult AtualizarReceita(int id, [FromBody] UpdateReceitaDto receitaDto)
        {
            Result resultado = _receitaService.AtualizarReceita(id, receitaDto);
            if(resultado.IsFailed)
            {
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }

        //Método para Deletar Receita Genérica específica por ID
        [HttpDelete("{id}")]
        public IActionResult DeletarReceita(int id)
        {
            Result resultado = _receitaService.DeletarReceita(id);
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
