using AluraMovies.Data;
using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/session")]
    public class SessionController : ControllerBase
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public SessionController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Session>> Get()
        {
            return Ok(_context.Sessions);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadSessionDto> GetById([FromRoute] int id)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return NotFound();

            ReadSessionDto dto = _mapper.Map<ReadSessionDto>(session);

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return NotFound();

            _context.Sessions.Remove(session);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] CreateSessionDto dto)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return NotFound();

            session = _mapper.Map(dto, session);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateSessionDto dto)
        {
            Session session = _mapper.Map<Session>(dto);

            _context.Sessions.Add(session);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { session.Id }, session);
        }
    }
}
