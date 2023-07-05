using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.Endereco,
                       option => option.MapFrom(cinema => cinema.Endereco))
            .ForMember(cinemaDto => cinemaDto.Sessoes,
                       option => option.MapFrom(cinema => cinema.Sessoes));
    }
}