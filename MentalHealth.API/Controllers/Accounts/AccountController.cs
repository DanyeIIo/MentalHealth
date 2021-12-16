using MentalHealth.Core.Models.Requests.Account;
using MentalHealth.Core.Models.Responses.Account;
using MentalHealth.Core.Services;
using MentalHealth.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.API.Controllers.Accounts
{
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(typeof(AuthenticationResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Register(RegisterRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _userService.RegisterAsync(request, IdManager.UserRoleId, cancellationToken);

            if (!response.IsSuccess)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(AuthenticationResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Login(LoginRequest model, CancellationToken cancellationToken = default)
        {
            var response = await _userService.LoginAsync(model, cancellationToken);

            if (!response.IsSuccess)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet("me")]
        [ProducesResponseType(typeof(Core.Models.User), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMe(CancellationToken cancellationToken = default)
        {
            var user = await _userService.GetMeAsync(User, cancellationToken);
            
            var response = new Core.Models.User
            {
                Email = user.Email,
                BirthDate = user.BirthDate,
                Id = user.Id,
                RoleId = user.RoleId,
                RoleName = user.RoleName
            };
            return Ok(response);
        }
    }
}
