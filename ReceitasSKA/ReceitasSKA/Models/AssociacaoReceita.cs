using System.ComponentModel.DataAnnotations;

namespace ReceitasSKA.Models
{
    public class AssociacaoReceita
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Código do Produto é obrigatório")]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "O campo Código da Receita é obrigatório")]
        public virtual Receita Receita { get; set; } //Casos 1:1

        public int ReceitaId { get; set; } //Casos 1:1

        //public virtual Receita Receita { get; set; } Casos 1:N
        //public int ReceitaId { get; set; } Casos 1:N

        [Required(ErrorMessage = "O campo Código do Recurso é obrigatório")]
        public int CodigoRecurso { get; set; }

        [Required(ErrorMessage = "O campo Lote Padrão é obrigatório")]
        public string LotePadrao { get; set; }

        [Range(0.1, 10000000)]
        public float TempoPadrao { get; set; }
    }
}
