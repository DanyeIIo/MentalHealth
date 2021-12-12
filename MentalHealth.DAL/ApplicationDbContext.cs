using MentalHealth.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Emotion> Emotions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
