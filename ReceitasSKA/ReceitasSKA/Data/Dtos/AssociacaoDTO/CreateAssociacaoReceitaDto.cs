using ReceitasSKA.Models;
using System.ComponentModel.DataAnnotations;

namespace ReceitasSKA.Data.Dtos.AssociacaoDTO
{
    public class CreateAssociacaoReceitaDto
    {
        [Required(ErrorMessage = "O campo Código do Produto é obrigatório")]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "O campo Código da Receita é obrigatório")]

        public int ReceitaId { get; set; } //Tanto casos 1:1 quanto 1:N

        [Required(ErrorMessage = "O campo Código do Recurso é obrigatório")]
        public int CodigoRecurso { get; set; }

        [Required(ErrorMessage = "O campo Lote Padrão é obrigatório")]
        public string LotePadrao { get; set; }

        [Range(0.1, 10000000)]
        public float TempoPadrao { get; set; }
    }
}
