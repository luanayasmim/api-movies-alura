﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "A propriedade Nome é obrigatória")]
    public string Nome { get; set; }
}
