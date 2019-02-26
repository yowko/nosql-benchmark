using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace NoSQL_Benchmark
{
    public abstract class NoSQLAbstract
    {
        [Params(100, 10000, 1000000)] public int Times { get; set; }
        public abstract Task InsertTest();
    }
}