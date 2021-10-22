using AluraMovies.Data;
using AluraMovies.Dtos.Manager;
using AluraMovies.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/manager")]
    public class ManagerController : ControllerBase
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public ManagerController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Manager>> Get()
        {
            return Ok(_context.Managers);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadManagerDto> GetById([FromRoute] int id)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return NotFound();

            ReadManagerDto dto = _mapper.Map<ReadManagerDto>(manager);

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return NotFound();

            _context.Managers.Remove(manager);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateManagerDto dto)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return NotFound();

            manager = _mapper.Map(dto, manager);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateManagerDto dto)
        {
            Manager manager = _mapper.Map<Manager>(dto);

            _context.Managers.Add(manager);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = manager.Id }, manager);
        }
    }
}
