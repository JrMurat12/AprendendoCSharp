using APILoja.Entidades;
using APILoja.Repositorios;
using Microsoft.AspNetCore.Mvc;


namespace APILoja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CamisetasController
    {
        static RepositorioCamiseta RepoCamiseta = new RepositorioCamiseta();

        [HttpPost]
        public string Add(Camiseta camiseta)
        {

            string retorno = RepoCamiseta.Adicionar(camiseta);

            return retorno;
        }
    }
}
