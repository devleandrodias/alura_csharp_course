using AluraMovies.Data;
using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/movie-theater")]
    public class MovieTheaterController : ControllerBase
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public MovieTheaterController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieTheater>> Get([FromQuery] string movieName)
        {
            List<MovieTheater> movieTheaters = _context.MovieTheaters.ToList();

            if (movieTheaters == null) return NotFound();

            if (!string.IsNullOrEmpty(movieName))
            {
                IEnumerable<MovieTheater> query = from movieTheater in movieTheaters
                                                  where movieTheater.Sessions.Any(x => x.Movie.Title == movieName)
                                                  select movieTheater;

                movieTheaters = query.ToList();
            }

            return Ok(movieTheaters);
        }

        [HttpGet("{id}")]
        public ActionResult<MovieTheater> GetById([FromRoute] int id)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return NotFound();

            return Ok(movieTheater);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateMovieTheaterDto dto)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return NotFound();

            movieTheater = _mapper.Map(dto, movieTheater);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(x => x.Id.Equals(id));

            if (movieTheater == null) return NotFound();

            _context.MovieTheaters.Remove(movieTheater);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Add([FromBody] CreateMovieTheaterDto dto)
        {
            MovieTheater movieTheater = _mapper.Map<MovieTheater>(dto);

            _context.MovieTheaters.Add(movieTheater);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = movieTheater.Id }, movieTheater);
        }
    }
}
