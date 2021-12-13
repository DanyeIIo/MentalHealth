using System;

namespace MentalHealth.DAL.Entities
{
    public class TestResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime PassedDate { get; set; } = DateTime.Now;
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}