﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório!")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "Gênero deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve ter entre 1 e 600 minutos!")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
