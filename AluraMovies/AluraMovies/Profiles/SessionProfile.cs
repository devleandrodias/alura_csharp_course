using AluraMovies.Dtos.Session;
using AluraMovies.Models;
using AutoMapper;

namespace AluraMovies.Profiles
{
    public class SessionProfile : Profile
    {
        public SessionProfile()
        {
            CreateMap<CreateSessionDto, Session>();
            CreateMap<UpdateSessionDto, Session>();

            CreateMap<Session, ReadSessionDto>()
                .ForMember(x => x.OpeningTime, opt =>
                    opt.MapFrom(x => 
                        x.ClosingTime.AddMinutes(x.Movie.Duration * (-1))));
        }
    }
}
