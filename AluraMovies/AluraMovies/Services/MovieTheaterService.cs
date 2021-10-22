using AluraMovies.Data;
using AluraMovies.Dtos.MovieTheater;
using AluraMovies.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Services
{
    public class MovieTheaterService
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public MovieTheaterService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadMovieTheaterDto> Get([FromQuery] string movieName)
        {
            List<MovieTheater> movieTheaters = _context.MovieTheaters.ToList();

            if (movieTheaters == null) return null;

            if (!string.IsNullOrEmpty(movieName))
            {
                IEnumerable<MovieTheater> query = from movieTheater in movieTheaters
                                                  where movieTheater.Sessions.Any(x => x.Movie.Title == movieName)
                                                  select movieTheater;

                movieTheaters = query.ToList();
            }

            return _mapper.Map<List<ReadMovieTheaterDto>>(movieTheaters);
        }

        public ReadMovieTheaterDto GetById([FromRoute] int id)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return null;

            return _mapper.Map<ReadMovieTheaterDto>(movieTheater);
        }

        public Result Update([FromRoute] int id, [FromBody] UpdateMovieTheaterDto dto)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return Result.Fail("Movie theater not found!");

            movieTheater = _mapper.Map(dto, movieTheater);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete([FromRoute] int id)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return Result.Fail("Movie theater not found!");

            _context.MovieTheaters.Remove(movieTheater);

            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadMovieTheaterDto Create([FromBody] CreateMovieTheaterDto dto)
        {
            MovieTheater movieTheater = _mapper.Map<MovieTheater>(dto);

            _context.MovieTheaters.Add(movieTheater);

            _context.SaveChanges();

            return _mapper.Map<ReadMovieTheaterDto>(movieTheater);
        }
    }
}
