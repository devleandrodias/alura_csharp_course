using AluraMovies.Dtos;
using AluraMovies.Models;
using AutoMapper;

namespace AluraMovies.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CreateAddressDto, Address>();
            CreateMap<UpdateAddressDto, Address>();
        }
    }
}
