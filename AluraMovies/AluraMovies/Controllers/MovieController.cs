using AluraMovies.Data;
using AluraMovies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/movie")]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById([FromRoute] int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie != null) return Ok();

            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] Movie data)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null) return NotFound();

            movie.Title = data.Title;
            movie.Duration = data.Duration;
            movie.Director = data.Director;
            movie.Category = data.Category;

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
        public ActionResult Add([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = movie.Id }, movie);
        }
    }
}

