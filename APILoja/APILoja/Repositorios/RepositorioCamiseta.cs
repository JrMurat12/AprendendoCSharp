using APILoja.Entidades;

namespace APILoja.Repositorios
{
    public class RepositorioCamiseta
    {
        List<Camiseta> Camisetas = new List<Camiseta>();
        
        public string Adicionar(Camiseta camiseta)
        {
            Camisetas.Add(camiseta);
            int proxID = Camisetas.Max(x => x.id) + 1;
            camiseta.id = proxID;
            return $"Camiseta da {camiseta.marca} {camiseta.id} adicionada com sucesso";
        } 
    }
}
