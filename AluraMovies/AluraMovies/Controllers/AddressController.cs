using AluraMovies.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AluraMovies.Models;
using System.Linq;
using AluraMovies.Dtos.Address;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/address")]
    public class AddressController : ControllerBase
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public AddressController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Address>> Get()
        {
            return Ok(_context.Address);
        }

        [HttpGet("{id}")]
        public ActionResult<Address> GetById([FromRoute] int id)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return NotFound();

            return Ok(address);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateAddressDto dto)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return NotFound();

            address = _mapper.Map(dto, address);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return NotFound();

            _context.Address.Remove(address);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Add([FromBody] CreateAddressDto dto)
        {
            Address address = _mapper.Map<Address>(dto);

            _context.Address.Add(address);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = address.Id }, address);
        }
    }
}
