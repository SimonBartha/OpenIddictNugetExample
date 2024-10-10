using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace OpenIddictNugetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpenIddictMongoDbBuilder mongoBuilder = null;

            mongoBuilder.UseDatabase(
                new MongoClient(MongoClientSettings.FromConnectionString("Test"))
                .GetDatabase("Test")
            );
        }
    }
}
