using System;

namespace MentalHealth.DAL.Entities
{
    public class ExperienceWords
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int UsedPercentage { get; set; } // i++
        public Guid TestResultId { get; set; }
        public TestResult TestResult { get; set; }
    }
}