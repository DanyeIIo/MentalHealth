using MentalHealth.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL
{
    public class DemoData
    {
        public List<Role> Roles { get; set; } = new();
        public List<User> Users { get; set; } = new();

        public DemoData()
        {
            var adminRole = new Role
            {
                Id = IdManager.AdminRoleId,
                Name = "Admin",
            };
            var userRole = new Role
            {
                Id = IdManager.UserRoleId,
                Name = "User",
            };
            var psychologistRole = new Role
            {
                Id = IdManager.PsychologistRoleId,
                Name = "Psychologist",
            };
            Roles.AddRange(new[] { adminRole, userRole, psychologistRole });

            var admin = new User
            {
                BirthDate = new(2003, 08, 22),
                Email = "admin@mail.ru",
                JobTitle = "admin",
                PasswordHash = "",
                Id = IdManager.Admin,
                RegistrationDate = DateTime.Now,
                Role = adminRole,
                RoleId = IdManager.AdminRoleId
            };
            Users.Add(admin);
        }
    }
}
