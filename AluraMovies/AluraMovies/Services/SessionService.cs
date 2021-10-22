using AluraMovies.Data;
using AluraMovies.Dtos.Session;
using AluraMovies.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AluraMovies.Services
{
    public class SessionService
    {
        private readonly MovieContext _context;

        private readonly IMapper _mapper;

        public SessionService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Session> Get()
        {
            return _context.Sessions.ToList();
        }

        public ReadSessionDto GetById([FromRoute] int id)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return null;

            return _mapper.Map<ReadSessionDto>(session);
        }

        public Result Delete([FromRoute] int id)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return Result.Fail("Session not found");

            _context.Sessions.Remove(session);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Update([FromRoute] int id, [FromBody] CreateSessionDto dto)
        {
            Session session = _context.Sessions.FirstOrDefault(x => x.Id.Equals(id));

            if (session == null) return Result.Fail("Session not found!");

            session = _mapper.Map(dto, session);

            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadSessionDto Create([FromBody] CreateSessionDto dto)
        {
            Session session = _mapper.Map<Session>(dto);

            _context.Sessions.Add(session);

            _context.SaveChanges();

            return _mapper.Map<ReadSessionDto>(session);
        }
    }
}
