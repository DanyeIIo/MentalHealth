using MentalHealth.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MentalHealth.API.Controllers
{
    
    [ApiController]
    public class RolesController : ControllerBase
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
       
        [HttpPost("api/role/create")]
        public async Task<IActionResult> Create(string name)
        {
            IdentityResult result;
            try
            {
                result = await _roleManager.CreateAsync(new IdentityRole(name));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
            
            return Ok(result);
        }
    }
}
