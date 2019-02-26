using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using CouchDB.Client;

namespace NoSQL_Benchmark
{
    public class CouchDBTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            var connectionString = "http://localhost:5984/";
            var client = new CouchClient(connectionString);
            var db = await client.GetDatabaseAsync("benchmark");
            var fakesUsers = UserUtility.GetFakeUsers(Times);
            foreach (var userList in UserUtility.SpiltBySize(fakesUsers, 10000))
            {
                await db.BulkInsertAsync(userList.ToArray());
            }
        }
    }
}