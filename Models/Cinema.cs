using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "A propriedade Nome é obrigatória")]
    public string Nome { get; set; }

    // Relação de 1:1 com o Endereço
    public int EnderecoId { get; set; }
    public virtual Endereco Endereco { get; set; } //Essa propriedade se dá para o Entity entender que a relação é de 1:1

    //Relacionamento de 1:n
    //Uma sessão esta para apenas um cinema, porém um cinema pode ter várias sessões
    public virtual ICollection<Sessao> Sessoes { get; set; }
}
