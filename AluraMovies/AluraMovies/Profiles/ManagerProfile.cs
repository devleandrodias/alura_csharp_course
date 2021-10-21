using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;
using System.Linq;

namespace AluraMovies.Profiles
{
    public class ManagerProfile : Profile
    {
        public ManagerProfile()
        {
            CreateMap<CreateManagerDto, Manager>();
            CreateMap<UpdateManagerDto, Manager>();

            CreateMap<Manager, ReadManagerDto>()
                .ForMember(manager => manager.MovieTheaters, opts =>
                    opts.MapFrom(manager => 
                        manager.MoviesTheaters.Select(x => new { x.Id, x.Name, x.Address })));
        }
    }
}
