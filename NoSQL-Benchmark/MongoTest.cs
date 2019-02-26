using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using MongoDB.Driver;

namespace NoSQL_Benchmark
{
    public class MongoTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("benchmark");
            var collection = db.GetCollection<User>("users");
            var fakesUsers = UserUtility.GetFakeUsers(Times);

            await collection.InsertManyAsync(fakesUsers);
        }
    }
}