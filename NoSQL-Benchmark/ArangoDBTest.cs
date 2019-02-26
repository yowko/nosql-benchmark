using System.Net;
using System.Threading.Tasks;
using ArangoDB.Client;
using BenchmarkDotNet.Attributes;

namespace NoSQL_Benchmark
{
    public class ArangoDBTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            ArangoDatabase.ChangeSetting(s =>
            {
                s.Database = "benchmark";
                s.Url = "http://localhost:8529";

                // you can set other settings if you need
                s.Credential = new NetworkCredential("root", "pass.123");
                s.SystemDatabaseCredential = new NetworkCredential("root", "pass.123");
            });
            var fakesUsers = UserUtility.GetFakeUsers(Times);
            using (var db = ArangoDatabase.CreateWithSetting())
            {
                foreach (var userList in UserUtility.SpiltBySize(fakesUsers, 10000))
                {
                    db.Collection("Users").InsertMultiple(userList);
                }
            }
        }
    }
}