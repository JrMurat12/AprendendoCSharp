using APILoja.Entidades;
using APILoja.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;


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

        [HttpGet ("{id}")]
        public object Consult(int id)
        {

            object retorno = RepoCamiseta.Consultar(id);

            return retorno;
        }
    }
}
