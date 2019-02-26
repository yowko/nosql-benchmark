using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Raven.Client.Documents;
using Raven.Client.Documents.BulkInsert;

namespace NoSQL_Benchmark
{
    public class RavenDBTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            var store = new DocumentStore
            {
                Urls = new string[] {"http://localhost:8080"},
            };
            store.Initialize();
            var fakeuserUSers = UserUtility.GetFakeUsers(Times);
            using (BulkInsertOperation bulkInsert = store.BulkInsert("benchmark"))
            {
                foreach (var user in fakeuserUSers)
                {
                    bulkInsert.Store(user);
                }
            }
        }
    }
}