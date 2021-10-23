using AluraAuth.Dtos;
using AluraAuth.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AluraAuth.Services
{
    public class SignUpService
    {
        private readonly IMapper _mapper;

        private readonly UserManager<IdentityUser<int>> _userManager;

        public SignUpService(IMapper mapper, UserManager<IdentityUser<int>> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Result SignUp(SignUpDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityUser<int> userIdentity = _mapper.Map<IdentityUser<int>>(user);

            Task<IdentityResult> result = _userManager.CreateAsync(userIdentity, dto.Password);

            if (!result.Result.Succeeded) return Result.Fail("");

            return Result.Ok();
        }
    }
}
