using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Bogus;

namespace NoSQL_Benchmark
{
    class Program
    {

        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<MongoTest>();
            //var summary = BenchmarkRunner.Run<CassandraTest>();
            //var summary = BenchmarkRunner.Run<CouchDBTest>();
            //var summary = BenchmarkRunner.Run<RavenDBTest>();
            //var summary = BenchmarkRunner.Run<ArangoDBTest>();
            var summary = BenchmarkRunner.Run<PostgreSQLTest>();

        }

        

        
    }

}