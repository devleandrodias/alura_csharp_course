using AluraMovies.Dtos.Movie;
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
            CreateMap<Movie, ReadMovieDto>();
        }
    }
}
