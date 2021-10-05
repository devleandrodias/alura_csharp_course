using MongoDB.Driver;

namespace ExamplesMongoDb
{
    internal class MongoDbConnector
    {
        public const string STRING_CONNECTION = "mongodb://balta:e296cd9f@localhost:27017/admin";
        public const string DATABASE = "library";
        public const string COLLECTION = "books";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbConnector()
        {
            _client = new MongoClient(STRING_CONNECTION);
            _database = _client.GetDatabase(DATABASE);
        }

        public IMongoClient Client { get { return _client; } }

        public IMongoCollection<Book> Books { get { return _database.GetCollection<Book>(COLLECTION); } }
    }
}
