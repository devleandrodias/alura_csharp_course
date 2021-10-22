using AluraMovies.Data;
using AluraMovies.Dtos.Movie;
using AluraMovies.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Services
{
    public class MovieService
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public MovieService(MovieContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<ReadMovieDto> Get([FromQuery] string category)
        {
            List<Movie> movies;

            if (string.IsNullOrEmpty(category))
            {
                movies = _context.Movies.ToList();
            }

            else
            {
                movies = _context.Movies
                    .Where(x => x.Category.ToUpper() == category.ToUpper())
                    .ToList();
            }

            if (movies == null) return null;

            return _mapper.Map<List<ReadMovieDto>>(movies);
        }

        public ReadMovieDto GetById([FromRoute] int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            return _mapper.Map<ReadMovieDto>(movie);
        }

        public Result Update([FromRoute] int id, [FromBody] UpdateMovieDto dto)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null) return Result.Fail("Movie not found!");

            movie = _mapper.Map(dto, movie);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete([FromRoute] int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null) return Result.Fail("Movie not found!");

            _context.Movies.Remove(movie);

            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadMovieDto Add([FromBody] CreateMovieDto movieDto)
        {
            Movie movie = _mapper.Map<Movie>(movieDto);

            _context.Movies.Add(movie);

            _context.SaveChanges();

            return _mapper.Map<ReadMovieDto>(movie);
        }
    }
}
