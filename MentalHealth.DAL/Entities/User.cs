using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Email { get; set; }
        
        public string PasswordHash { get; set; }

        public DateTime BirthDate { get; set; }

        public string JobTitle { get; set; }

        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public List<TestResult> TestResults { get; set; } = new();
    }
}
