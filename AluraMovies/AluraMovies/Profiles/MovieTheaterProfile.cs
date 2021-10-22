using AluraMovies.Dtos.MovieTheater;
using AluraMovies.Models;
using AutoMapper;

namespace AluraMovies.Profiles
{
    public class MovieTheaterProfile : Profile
    {
        public MovieTheaterProfile()
        {
            CreateMap<CreateMovieTheaterDto, MovieTheater>();
            CreateMap<UpdateMovieTheaterDto, MovieTheater>();
            CreateMap<MovieTheater, ReadMovieTheaterDto>();
        }
    }
}
