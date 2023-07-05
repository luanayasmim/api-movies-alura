using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }

    // Relação de 1:1 com Cinema
    public int CinemaId { get; set; }
    public virtual Cinema Cinema { get; set; } //Essa propriedade se dá para o Entity entender que a relação é de 1:1
}