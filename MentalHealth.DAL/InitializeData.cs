using MentalHealth.Core;
using MentalHealth.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL
{
    public class InitializeData
    {
        public User Admin { get; }
        public User User { get; }
        public User Psychologist { get; }

        public Role AdminRole { get; }
        public Role UserRole { get; }
        public Role PsycholigistRole { get; }

        public InitializeData(IHasher hasher)
        {
            AdminRole = new()
            {
                Name = "Admin",
                Id = IdManager.AdminRoleId,
            };

            UserRole = new()
            {
                Name = "User",
                Id = IdManager.UserRoleId
            };

            Admin = new()
            {
                Id = IdManager.Admin,
                BirthDate = new(2003, 08, 22),
                Email = "admin@mail.ru",
                RoleId = IdManager.AdminRoleId,
                JobTitle = "Admin",
                RegistrationDate = DateTime.UtcNow,
            };

            var admin = new Core.Models.User
            {
                Email = Admin.Email,
            };
            Admin.PasswordHash = hasher.HashPassword(admin, "password");
        }

    }
}
