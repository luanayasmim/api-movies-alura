using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "A propriedade Nome é obrigatória")]
    public string Nome { get; set; }
}
