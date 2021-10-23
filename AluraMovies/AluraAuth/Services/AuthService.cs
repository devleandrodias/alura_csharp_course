using AluraAuth.Dtos;
using AluraAuth.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace AluraAuth.Services
{
    public class AuthService
    {
        private readonly IMapper _mapper;

        private readonly UserManager<IdentityUser<int>> _userManager;

        private readonly SignInManager<IdentityUser<int>> _signInManager;

        private readonly TokenService _tokenService;

        public AuthService(
            IMapper mapper,
            UserManager<IdentityUser<int>> userManager,
            SignInManager<IdentityUser<int>> signInManager,
            TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public Result SignUp(SignUpDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityUser<int> userIdentity = _mapper.Map<IdentityUser<int>>(user);

            Task<IdentityResult> result = _userManager.CreateAsync(userIdentity, dto.Password);

            if (!result.Result.Succeeded) return Result.Fail("Sign up fail!");

            return Result.Ok();
        }

        public Result SignIn(SignInDto dto)
        {
            Task<SignInResult> result = _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

            if (!result.Result.Succeeded) return Result.Fail("Sign in fail!");

            IdentityUser<int> identityUser = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(x => x.NormalizedUserName.Equals(dto.UserName.ToUpper()));

            Token token = _tokenService.CreateToken(identityUser);

            return Result.Ok().WithSuccess(token.Value);
        }
    
        public Result SignOut()
        {
            Task result = _signInManager.SignOutAsync();

            if (!result.IsCompletedSuccessfully) return Result.Fail("Sign out fail!");

            return Result.Ok();
        }
    }
}
