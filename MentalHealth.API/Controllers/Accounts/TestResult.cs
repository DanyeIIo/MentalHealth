using MentalHealth.DAL;
using MentalHealth.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.API.Controllers.Accounts
{
    [Route("Account/TestResult/")]
    [ApiController]
    public class TestResult : ControllerBase
    {
        //private readonly IUserTestResult _userService;
        private readonly ApplicationDbContext _context;

        public TestResult(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "User")]
        [HttpGet("GetUserTestResultsLast30days")]
        [ProducesResponseType(typeof(List<TestResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTestResultsAsync(Guid id, CancellationToken cancellationToken)
        {
            var res = await _context.TestResults.Where(x => x.UserId == id && DateTime.Now < x.PassedDate.AddDays(30)).ToListAsync(cancellationToken);
            return Ok(res);
        }
    }
}
