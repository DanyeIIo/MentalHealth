using AutoMapper;
using MentalHealth.API.Models;
using MentalHealth.BL.DTO;
using MentalHealth.BL.Infrastucture;
using MentalHealth.BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MentalHealth.API.Controllers
{    
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private ITokenRefresher _tokenRefresher;

        IMapper mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<LoginModel, UserDTO>();            
            cfg.CreateMap<RegistrationModel, UserDTO>();
        }).CreateMapper();

        public AuthController(IAuthService authService, ITokenRefresher tokenRefresher)
        {
            _authService = authService;
            _tokenRefresher = tokenRefresher;
        }

        [HttpPost("api/auth/register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            IdentityResult result;
            try
            {
                result = await _authService.Register(mapper.Map<RegistrationModel, UserDTO>(model));
            }            
            catch (Exception)
            {
                return StatusCode(500);
            }
            return Ok(result);
        }

        [HttpPost("api/auth/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            AuthenticationResponse token;
            try
            {
                token = await _authService.Login(mapper.Map<LoginModel, UserDTO>(model));
            }            
            catch (Exception)
            {
                return StatusCode(500);
            }
            return Ok(token);
        }

        [HttpPost("api/auth/refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh(AuthenticationResponse authenticationResponse)
        {
            AuthenticationResponse token;
            try
            {
                token = await _tokenRefresher.Refresh(authenticationResponse);
            }            
            catch (Exception)
            {
                return StatusCode(500);
            }
            return Ok(token);
        }

    }
}
