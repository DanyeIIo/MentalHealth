using System;
using System.Collections.Generic;

namespace MentalHealth.DAL.Entities
{
    public class TestResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime PassedDate { get; set; } = DateTime.Now;
        public Guid UserId { get; set; }
        public Guid FeelingId { get; set; }
        public string Story { get; set; }
        public User User { get; set; }
        public Feeling Feeling { get; set; }
        public List<ExperienceWords> ExperienceWords { get; set; } = new();
    }
}