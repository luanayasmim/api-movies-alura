using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Sessao
{
    //Relacionamento de 1:n
    //Uma sessão pode conter apenas um filme, porém um filme pode estar em várias sessões
    public int? FilmeId { get; set; }
    public virtual Filme Filme  { get; set; }

    //Uma sessão esta para apenas um cinema, porém um cinema pode ter várias sessões
    public int? CinemaId { get; set; }
    public virtual Cinema Cinema { get; set; }
}