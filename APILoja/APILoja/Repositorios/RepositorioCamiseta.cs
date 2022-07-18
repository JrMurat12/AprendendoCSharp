using APILoja.Entidades;
using System.Linq;
using System.Collections.Generic;

namespace APILoja.Repositorios
{
    public class RepositorioCamiseta
    {
        List<Camiseta> Camisetas = new List<Camiseta>();

        public string Adicionar(Camiseta camiseta)
        {
            int proxID = 1;

            if (Camisetas.Any())
            {
                proxID = Camisetas.Max(x => x.id) + 1;
            }
            camiseta.id = proxID;
            Camisetas.Add(camiseta);

            return $"Camiseta da {camiseta.marca} ID: {camiseta.id} adicionada com sucesso";
        }

        public object Consultar(int IDrecebe)
        {
            var consultaID = from Camisetas in Camisetas
                             where Camisetas.id == IDrecebe
                             select Camisetas;
            return consultaID;
        } 
    }
}
