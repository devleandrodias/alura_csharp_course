using AluraMovies.Dtos.Manager;
using AluraMovies.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/manager")]
    public class ManagerController : ControllerBase
    {
        private readonly ManagerService _service;

        public ManagerController(ManagerService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Manager>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<ReadManagerDto> GetById([FromRoute] int id)
        {
            ReadManagerDto manager = _service.GetById(id);

            if (manager == null) return NotFound();

            return Ok(manager);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Result result = _service.Delete(id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateManagerDto dto)
        {
            Result result = _service.Update(id, dto);

            if (result == null) return NotFound();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateManagerDto dto)
        {
            ReadManagerDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }
    }
}
