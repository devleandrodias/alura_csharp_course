using AluraAuth.Dtos;
using AluraAuth.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AluraAuth.Controllers
{
    [ApiController, Route("v1/sign-up")]
    public class SignUpController : ControllerBase
    {
        private readonly SignUpService _service;

        public SignUpController(SignUpService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult SignUp(SignUpDto dto)
        {
            Result result = _service.SignUp(dto);

            if (result.IsFailed) return StatusCode(500);

            return Ok();
        }
    }
}
