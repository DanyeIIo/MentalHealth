using MentalHealth.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Emotion> Emotions { get; set; }
    }
}
