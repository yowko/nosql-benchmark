using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;

namespace NoSQL_Benchmark
{
    public class PostgreSQLTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            string connString =
                "Server=127.0.0.1; User Id=postgres; Database=benchmark; Port=5432; Password=pass.123; SSL Mode=Prefer; Trust Server Certificate=true";
            var fakeuserUSers = UserUtility.GetFakeUsers(Times).Select(a=>JsonConvert.SerializeObject(a));
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();


                using (var writer =
                    conn.BeginBinaryImport(
                        "COPY test.users (\"User\") FROM STDIN (FORMAT BINARY)")
                )
                {
                    foreach (var user in fakeuserUSers)
                    {
                        writer.StartRow();
                        writer.Write(user, NpgsqlDbType.Json);
                    }


                    writer.Complete();
                }
            }
        }
    }
}