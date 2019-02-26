using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Cassandra;

namespace NoSQL_Benchmark
{
    public class CassandraTest : NoSQLAbstract
    {
        [Benchmark]
        public override async Task InsertTest()
        {
            var cluster = Cluster.Builder()
                .AddContactPoints("127.0.0.1")
                .WithPort(9042)
                .Build();

            var session = cluster.Connect("benchmark");

            var userttemplate =
                session.Prepare("INSERT INTO users (userid, name, birthday, currentsalary) VALUES (?, ?, ?, ?)");


            foreach (var userList in UserUtility.SpiltBySize(UserUtility.GetFakeUsers(Times), 100))
            {
                var batch = new BatchStatement();
                foreach (var _user in userList)
                {
                    batch.Add(userttemplate.Bind(_user.UserId, _user.Name, _user.Birthday, _user.CurrentSalary));
                }

                session.Execute(batch);
            }
        }
    }
}