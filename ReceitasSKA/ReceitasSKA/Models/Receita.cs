using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ReceitasSKA.Models
{
    ///Atributos encontrados na tela Inicial do Protheus -> Módulo 10 -> Miscelâneas -> Receitas Genéricas
    public class Receita
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

        //[JsonIgnore]
        //public virtual AssociacaoReceita AssociacaoReceita { get; set; } // Casos 1:1

        //[JsonIgnore]
        //public virtual List<AssociacaoReceita> AssociacaoReceitaList { get; set; } Casos 1:N

    }
}
