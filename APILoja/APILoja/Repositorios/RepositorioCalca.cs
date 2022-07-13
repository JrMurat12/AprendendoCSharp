using APILoja.Entidades;

namespace APILoja.Repositorios
{
    public class RepositorioCalca
    {
        List<Calca> Calcas = new List<Calca>();
        public string Adicionar(Calca calca)
        {
            Calcas.Add(calca);
            int proxID = Calcas.Max(x => x.id) + 1;
            calca.id = proxID;
            return $"Calça da {calca.marca} ID: {calca.id} adicionada com sucesso";
        }

    }
}
