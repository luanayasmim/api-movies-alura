using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class FilmeContext : DbContext
{
	public FilmeContext(DbContextOptions<FilmeContext> options) : base(options) 
	{
	}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //Chave composta para a tabela Sessoes de FilmeId e CinemaId
        builder.Entity<Sessao>()
            .HasKey(sessao => new { sessao.FilmeId, sessao.CinemaId });

        //Definindo Relação de n:n entre a tabela Cinema e Sessões
        builder.Entity<Sessao>()
            .HasOne(sessao => sessao.Cinema)
            .WithMany(cinema => cinema.Sessoes)
            .HasForeignKey(sessao => sessao.CinemaId);

        builder.Entity<Sessao>()
            .HasOne(sessao => sessao.Filme)
            .WithMany(filme => filme.Sessoes)
            .HasForeignKey(sessao => sessao.FilmeId);

        //Definindo o tipo de delete
        builder.Entity<Endereco>()
            .HasOne(endereco => endereco.Cinema)
            .WithOne(cinema => cinema.Endereco)
            .OnDelete(DeleteBehavior.Restrict);

        //Documentação: https://learn.microsoft.com/pt-br/ef/core/saving/cascade-delete
    }

    public DbSet<Filme> Filmes { get; set; } 
	public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
