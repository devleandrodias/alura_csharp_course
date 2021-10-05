using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ExamplesMongoDb
{
    internal class AccessingMongoDb
    {
        public static async void Execute()
        {
            BsonDocument book = new()
            {
                { "Title", "Game of Thrones" },
            };

            BsonArray assuntos = new();

            assuntos.Add("Fantasy");
            assuntos.Add("Action");

            book.Add("Author", "George R R Martin");
            book.Add("Year", 1999);
            book.Add("Pages", 856);
            book.Add("Subjects", assuntos);

            string stringConnection = "mongodb://balta:e296cd9f@localhost:27017/admin";

            IMongoClient client = new MongoClient(stringConnection);

            IMongoDatabase database = client.GetDatabase("library");

            IMongoCollection<BsonDocument> bookCollection = database.GetCollection<BsonDocument>("books");

            await bookCollection.InsertOneAsync(book);

            Console.WriteLine("New document add...");
        }
    }
}
