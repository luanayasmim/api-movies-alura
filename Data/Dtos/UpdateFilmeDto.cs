using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título não pode ser nulo")]
    [MaxLength(200, ErrorMessage = "O título deve conter no máximo 200 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero não pode ser nulo")]
    [StringLength(50, ErrorMessage = "O gênero deve contar no máximo 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração não pode ser nula")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
