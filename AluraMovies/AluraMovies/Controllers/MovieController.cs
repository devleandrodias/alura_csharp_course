using AluraMovies.Data;
using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/movie")]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get([FromQuery] string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return Ok(_context.Movies);
            }

            List<Movie> movies = _context.Movies
                .Where(x => x.Category.ToUpper() == category.ToUpper())
                .ToList();

            if (movies == null) return NotFound();

            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById([FromRoute] int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie != null) return Ok();

            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateMovieDto movieDto)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null) return NotFound();

            movie = _mapper.Map(movieDto, movie);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null) return NotFound();

            _context.Movies.Remove(movie);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Add([FromBody] CreateMovieDto movieDto)
        {
            Movie movie = _mapper.Map<Movie>(movieDto);

            _context.Movies.Add(movie);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = movie.Id }, movie);
        }
    }
}
