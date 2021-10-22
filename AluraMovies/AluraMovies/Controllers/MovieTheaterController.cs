using AluraMovies.Dtos.MovieTheater;
using AluraMovies.Models;
using AluraMovies.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/movie-theater")]
    public class MovieTheaterController : ControllerBase
    {
        private readonly MovieTheaterService _service;

        public MovieTheaterController(MovieTheaterService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieTheater>> Get([FromQuery] string movieName)
        {
            IEnumerable<ReadMovieTheaterDto> readDto = _service.Get(movieName);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadMovieTheaterDto> GetById([FromRoute] int id)
        {
            ReadMovieTheaterDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateMovieTheaterDto dto)
        {
            Result result = _service.Update(id, dto);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Result result = _service.Delete(id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateMovieTheaterDto dto)
        {
            ReadMovieTheaterDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }
    }
}
