using MentalHealth.DAL;
using MentalHealth.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.API.Controllers.Accounts
{
    [Route("api/Account/[controller]")]
    [ApiController]
    public class UserTestResult : ControllerBase
    {
        //private readonly IUserTestResult _userService;
        private readonly ApplicationDbContext _context;

        public UserTestResult(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetTestResult")]
        //[Authorize(Roles = "User")]
        //public async Task<List<IActionResult>> GetTestResultsAsync(Guid id, CancellationToken cancellationToken = default)
        //{
        //    var response = await _context.TestResults();

        //    if (!response.IsSuccess)
        //        return BadRequest(new { message = "Email or password is incorrect" });

        //    return Ok(response);
        //}
    }
}
