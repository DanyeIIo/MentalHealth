using MentalHealth.Core.Models;
using MentalHealth.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserAsync(User user, CancellationToken cancellationToken = default)
        {
            Entities.User newUser = new()
            {
                Id = user.Id,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                BirthDate = user.BirthDate,
                Role = _context.Roles.FirstOrDefault(x => x.Id == IdManager.UserRoleId),
                JobTitle = user.JobTitle,
                RoleId = IdManager.UserRoleId,
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id, cancellationToken);

            var newUser= new User
            {
                Id = user.Id,
                BirthDate = user.BirthDate,
                Email = user.Email,
                JobTitle = user.JobTitle,
                PasswordHash = user.PasswordHash,
                RoleId = user.RoleId,
                RoleName = user.Role.Name
            };
            return newUser;
        }

        public async Task<User> GetUserByNameAsync(string email, CancellationToken cancellationToken = default)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
            if (user is null)
                return null;
            
            return new User
            {
                Id = user.Id,
                BirthDate = user.BirthDate,
                Email = user.Email,
                JobTitle = user.JobTitle,
                PasswordHash = user.PasswordHash,
                RoleId = user.RoleId,
                RoleName = _context.Roles.FirstOrDefault(x => x.Id == user.RoleId).Name,
            };
        }
    }
}
