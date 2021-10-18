using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;

namespace AluraMovies.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();
        }
    }
}
