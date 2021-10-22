using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AluraMovies.Models;
using AluraMovies.Dtos.Address;
using FluentResults;
using AluraMovies.Services;

namespace AluraMovies.Controllers
{
    [ApiController, Route("v1/address")]
    public class AddressController : ControllerBase
    {
        private readonly AddressService _service;

        public AddressController(AddressService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadAddressDto>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Address> GetById([FromRoute] int id)
        {
            ReadAddressDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateAddressDto dto)
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
        public ActionResult Create([FromBody] CreateAddressDto dto)
        {
            ReadAddressDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }
    }
}
