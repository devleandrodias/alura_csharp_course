using AluraAuth.Dtos;
using AluraAuth.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AluraAuth.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SignUpDto, User>();
            CreateMap<User, IdentityUser<int>>();
        }
    }
}
