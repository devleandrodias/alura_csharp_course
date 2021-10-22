using AluraMovies.Dtos.Session;
using AluraMovies.Models;
using AluraMovies.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/session")]
    public class SessionController : ControllerBase
    {
        private readonly SessionService _service;

        public SessionController(SessionService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Session>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<ReadSessionDto> GetById([FromRoute] int id)
        {
            ReadSessionDto session = _service.GetById(id);

            if (session == null) return NotFound();

            return Ok(session);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Result result = _service.Delete(id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] CreateSessionDto dto)
        {
            Result result = _service.Update(id, dto);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateSessionDto dto)
        {
            ReadSessionDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }
    }
}
