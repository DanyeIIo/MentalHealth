using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalHealth.Core;
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

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        
        public DbSet<Feeling> Feelings { get; set; }
        public DbSet<ExperienceWords> ExperienceWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(x => x.JobTitle)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(x => x.Email)
                    .IsRequired();

                entity.HasOne(x => x.Role)
                    .WithMany(x => x.Users);

                entity.HasMany(x => x.TestResults)
                    .WithOne(x => x.User);
            });

            modelBuilder.Entity<TestResult>(entity =>
            {
                entity.Property(x => x.Story)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.HasOne(x => x.Feeling)
                    .WithMany(x => x.TestResults);

                entity.HasMany(x => x.ExperienceWords)
                    .WithOne(x => x.TestResult);
            });

            modelBuilder.Entity<ExperienceWords>(entity =>
            {
                entity.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });
        }
    }
}
