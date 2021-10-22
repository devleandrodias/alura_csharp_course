using AluraMovies.Data;
using AluraMovies.Dtos.Manager;
using AluraMovies.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Controllers
{
    public class ManagerService
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public ManagerService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Manager> Get()
        {
            return _context.Managers;
        }

        public ReadManagerDto GetById([FromRoute] int id)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return null;

            return _mapper.Map<ReadManagerDto>(manager);
        }

        public Result Delete([FromRoute] int id)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return Result.Fail("Manager not found!");

            _context.Managers.Remove(manager);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Update([FromRoute] int id, [FromBody] UpdateManagerDto dto)
        {
            Manager manager = _context.Managers.FirstOrDefault(x => x.Id.Equals(id));

            if (manager == null) return Result.Fail("Manager not found!");

            manager = _mapper.Map(dto, manager);

            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadManagerDto Create([FromBody] CreateManagerDto dto)
        {
            Manager manager = _mapper.Map<Manager>(dto);

            _context.Managers.Add(manager);

            _context.SaveChanges();

            return _mapper.Map<ReadManagerDto>(manager);
        }
    }
}
