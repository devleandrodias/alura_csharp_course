using AluraAuth.Dtos;
using AluraAuth.Models;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AluraAuth.Services
{
    public class AuthService
    {
        private readonly IMapper _mapper;

        private readonly UserManager<IdentityUser<int>> _userManager;

        private readonly SignInManager<IdentityUser<int>> _signInManager;

        private readonly TokenService _tokenService;

        private readonly EmailService _emailService;

        public AuthService(
            IMapper mapper,
            UserManager<IdentityUser<int>> userManager,
            SignInManager<IdentityUser<int>> signInManager,
            TokenService tokenService, 
            EmailService emailService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _emailService = emailService;
        }

        public Result SignUp(SignUpDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityUser<int> userIdentity = _mapper.Map<IdentityUser<int>>(user);

            Task<IdentityResult> result = _userManager.CreateAsync(userIdentity, dto.Password);

            if (!result.Result.Succeeded) return Result.Fail("Sign up fail!");

            string confirmationCode = _userManager.GenerateEmailConfirmationTokenAsync(userIdentity).Result;

            _emailService.SendEmail(new[] { userIdentity.Email }, "Confirmation link", userIdentity.Id, confirmationCode);

            string encodedCode = HttpUtility.UrlEncode(confirmationCode);

            return Result.Ok().WithSuccess(encodedCode);
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

        public Result ConfirmEmail(ConfirmEmailDto dto)
        {
            IdentityUser<int> identityUser = _userManager.Users.FirstOrDefault(x => x.Id.Equals(dto.UserId));

            IdentityResult identityResult = _userManager.ConfirmEmailAsync(identityUser, dto.ConfirmationCode).Result;

            if (!identityResult.Succeeded) return Result.Fail("Confirm e-mail fail!");

            return Result.Ok();
        }
    }
}
