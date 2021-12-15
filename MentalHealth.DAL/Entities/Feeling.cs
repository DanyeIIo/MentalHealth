using System;
using System.Collections.Generic;

namespace MentalHealth.DAL.Entities
{
    public class Feeling
    {
        public Guid Id { get; set; }
        public byte FeelPoint { get; set; } // 1 | 2 | 3 | 4 | 5
        public List<TestResult> TestResults { get; set; } = new();

    }
}