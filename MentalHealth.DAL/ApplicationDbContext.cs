using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalHealth.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth.DAL
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHasher _hasher;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHasher hasher)
            : base(options)
        {
            _hasher = hasher;
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
