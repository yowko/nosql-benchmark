using System;
using System.Collections.Generic;
using Bogus;

namespace NoSQL_Benchmark
{
    public static class UserUtility
    {
        public static List<User> GetFakeUsers(int times)
        {
            var fakesUsers = new Faker<User>()
                .RuleFor(a => a.UserId, f => f.Random.Guid())
                .RuleFor(a => a.Name, f => f.Name.FirstName())
                .RuleFor(a => a.Birthday, f => f.Date.Past())
                .RuleFor(a => a.CurrentSalary, f => f.Random.Decimal(0M, 10000M))
                .Generate(times);

            return fakesUsers;
        }
        
        public static List<T>[] SpiltBySize<T>(List<T> list, int size)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            if (size < 1)
                throw new ArgumentOutOfRangeException("totalPartitions");

            int count = (int) Math.Ceiling(list.Count / (double) size);
            List<T>[] partitions = new List<T>[count];

            int k = 0;
            for (int i = 0; i < partitions.Length; i++)
            {
                partitions[i] = new List<T>(size);
                for (int j = k; j < k + size; j++)
                {
                    if (j >= list.Count)
                        break;
                    partitions[i].Add(list[j]);
                }

                k += size;
            }

            return partitions;
        }
    }
}