using System.ComponentModel.DataAnnotations;

namespace ReceitasSKA.Data.Dtos.ReceitaDTO
{
    public class CreateReceitaDto
    {
        public string filial { get; set; }

        [Required(ErrorMessage = "O campo Código da Receita é obrigatório")]
        public float CodigoReceita { get; set; }

        [Range(0.1, 10000000)]
        public float VersaoPeso { get; set; }

        [Required(ErrorMessage = "O campo Lote Padrão é obrigatório")]
        public float LotePadrao { get; set; }

        [Range(0.1, 10000000)]
        public float TempoPadrao { get; set; }

        [Required(ErrorMessage = "O campo Código CT é obrigatório")]
        public string CodigoCT { get; set; }
    }
}
