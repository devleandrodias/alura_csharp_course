using AluraMovies.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AluraMovies.Models;
using System.Linq;
using AluraMovies.Dtos.Address;
using FluentResults;

namespace AluraMovies.Services
{
    public class AddressService
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public AddressService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadAddressDto> Get()
        {
            List<Address> addresses = _context.Address.ToList();

            return _mapper.Map<List<ReadAddressDto>>(addresses);
        }

        public ReadAddressDto GetById([FromRoute] int id)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return null;

            return _mapper.Map<ReadAddressDto>(address);
        }

        public Result Update([FromRoute] int id, [FromBody] UpdateAddressDto dto)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return Result.Fail("Address not found!");

            address = _mapper.Map(dto, address);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Delete([FromRoute] int id)
        {
            Address address = _context.Address.FirstOrDefault(x => x.Id == id);

            if (address == null) return Result.Fail("Address not found!");

            _context.Address.Remove(address);

            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadAddressDto Create([FromBody] CreateAddressDto dto)
        {
            Address address = _mapper.Map<Address>(dto);

            _context.Address.Add(address);

            _context.SaveChanges();

            return _mapper.Map<ReadAddressDto>(address);
        }
    }
}
