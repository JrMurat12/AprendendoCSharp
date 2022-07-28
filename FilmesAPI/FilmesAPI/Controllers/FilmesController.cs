using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmesController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //private static List<Filme> filmes = new List<Filme>();
        //private static int id = 1;


        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
        //public IActionResult AdicionarFilme([FromBody] Filme filme)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);

            //Filme filme = new Filme
            //{
            //    Titulo = filmeDto.Titulo,
            //    Genero = filmeDto.Genero,
            //    Duracao = filmeDto.Duracao,
            //    Diretor = filmeDto.Diretor,
            //};

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            //filme.Id = id++;
            //filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperarFilmesPorId), new {Id = filme.Id}, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        //public IActionResult RecuperarFilmes()
        {
            return _context.Filmes;
            //return Ok(_context.Filmes);
            //return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmesPorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);

                //ReadFilmeDto filmeDto = new ReadFilmeDto
                //{
                //    Titulo = filme.Titulo,
                //    Diretor = filme.Diretor,
                //    Duracao = filme.Duracao,
                //    Id = filme.Id,
                //    Genero = filme.Genero,
                //    HoraDaConsulta = DateTime.Now
                //};
                return Ok(filmeDto);
                //return Ok(filme);
            }
            return NotFound();

                //if (filme != null)
                //{
                //    return Ok(filme);
                //}
                //return NotFound();

                //Filme filme =  filmes.FirstOrDefault(filme => filme.Id == id);
                //if(filme != null)
                //{
                //    return Ok(filme);
                //}
                //return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        //public IActionResult AtualizaFilme(int id, [FromBody] Filme filmeNovo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                return NotFound();
            }
            _mapper.Map(filmeDto, filme);

            //filme.Titulo = filmeDto.Titulo;
            //filme.Genero = filmeDto.Genero;
            //filme.Duracao = filmeDto.Duracao;
            //filme.Diretor = filmeDto.Diretor;

            //filme.Titulo = filmeNovo.Titulo;
            //filme.Genero = filmeNovo.Genero;
            //filme.Duracao = filmeNovo.Duracao;
            //filme.Diretor = filmeNovo.Diretor;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                return NotFound();
            }
            _context.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
