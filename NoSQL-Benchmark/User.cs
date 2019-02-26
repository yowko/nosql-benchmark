using System;

namespace NoSQL_Benchmark
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public decimal CurrentSalary { get; set; }
    }
}