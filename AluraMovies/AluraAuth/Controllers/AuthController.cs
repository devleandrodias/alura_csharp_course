using AluraAuth.Dtos;
using AluraAuth.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace AluraAuth.Controllers
{
    [ApiController, Route("v1/auth")]
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService service)
        {
            _authService = service;
        }

        [HttpPost("sign-up")]
        public ActionResult AuthSignUp(SignUpDto dto)
        {
            Result result = _authService.SignUp(dto);

            if (result.IsFailed) return StatusCode(500);

            return Ok(result.Successes);
        }

        [HttpPost("sign-in")]
        public ActionResult AuthSignIn(SignInDto dto)
        {
            Result result = _authService.SignIn(dto);

            if (result.IsFailed) return Unauthorized(result.Errors);

            return Ok(result.Successes);
        }

        [HttpPost("sign-out")]
        public ActionResult AuthSignOut()
        {
            Result result = _authService.SignOut();

            if (result.IsFailed) return Unauthorized(result.Errors);

            return Ok(result.Successes);
        }
    
        [HttpGet("confirm-email")]
        public ActionResult AuthConfirmEmail([FromQuery] ConfirmEmailDto dto)
        {
            Result result = _authService.ConfirmEmail(dto);

            if (result.IsFailed) return StatusCode(500);

            return Ok(result.Successes);
        }
    }
}
