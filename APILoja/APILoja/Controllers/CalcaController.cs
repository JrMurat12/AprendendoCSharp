using APILoja.Entidades;
using APILoja.Repositorios;
using Microsoft.AspNetCore.Mvc;


namespace APILoja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcaController
    {
        static RepositorioCalca RepoCalca = new RepositorioCalca();

        [HttpPost]
        public string Add(Calca calca)
        {

            string retorno = RepoCalca.Adicionar(calca);

            return retorno;
        }
    }
}
