using ReceitasSKA.Models;
using System.ComponentModel.DataAnnotations;

namespace ReceitasSKA.Data.Dtos.AssociacaoDTO
{
    public class ReadAssociacaoReceitaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Código do Produto é obrigatório")]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "O campo Código da Receita é obrigatório")]

        public Receita Receita { get; set; }

        [Required(ErrorMessage = "O campo Código do Recurso é obrigatório")]
        public int CodigoRecurso { get; set; }

        [Required(ErrorMessage = "O campo Lote Padrão é obrigatório")]
        public string LotePadrao { get; set; }

        [Range(0.1, 10000000)]
        public float TempoPadrao { get; set; }

        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}
