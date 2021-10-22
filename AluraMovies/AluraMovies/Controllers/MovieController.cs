using AluraMovies.Dtos.Movie;
using AluraMovies.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/movie")]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _service;

        public MovieController(MovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<ReadMovieDto>> Get([FromQuery] string category)
        {
            List<ReadMovieDto> readDto = _service.Get(category);

            if (readDto.Count == 0) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadMovieDto> GetById([FromRoute] int id)
        {
            ReadMovieDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateMovieDto dto)
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
        public ActionResult Add([FromBody] CreateMovieDto dto)
        {
            ReadMovieDto readDto = _service.Add(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }
    }
}
