using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título não pode ser nulo")]
    [MaxLength(200, ErrorMessage = "O título deve conter no máximo 200 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero não pode ser nulo")]
    [MaxLength(50, ErrorMessage = "O gênero deve contar no máximo 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração não pode ser nula")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }

    //Relacionamento de 1:n
    //Uma sessão pode conter apenas um filme, porém um filme pode estar em várias sessões
    public virtual ICollection<Sessao> Sessoes { get; set; }
}
