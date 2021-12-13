using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.Core.Models
{
    public class User
    {
        public string Email { get; set; }

        public Guid Id { get; set; }

        public DateTime BirthDate { get; set; }

        public Guid RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
