using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamplesMongoDb
{
    internal class BookRepository
    {
        private static readonly MongoDbConnector _connector;

        static BookRepository()
        {
            _connector = new();
        }

        public static async Task Add()
        {
            List<string> subjects = new();

            subjects.Add("Fantasy");
            subjects.Add("Magic");

            Book harryPotter = new()
            {
                Title = "Harry Potter",
                Author = " J. K. Rowling",
                Pages = 233,
                Year = 2009,
                Subjects = subjects
            };

            string stringConnection = "mongodb://balta:e296cd9f@localhost:27017/admin";

            IMongoClient client = new MongoClient(stringConnection);

            IMongoDatabase database = client.GetDatabase("library");

            IMongoCollection<Book> bookCollection = database.GetCollection<Book>("books");

            await bookCollection.InsertOneAsync(harryPotter);

            Console.WriteLine("New document add...");
        }

        public static void Get()
        {
            MongoDbConnector connector = new();

            Console.WriteLine("Books...");

            List<Book> books = connector.Books.Find(new BsonDocument()).ToList();

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToJson());
            }
        }

        public static void GetWithFilterBson()
        {
            BsonDocument filters = new()
            {
                { "Author", "George R R Martin" }
            };

            List<Book> books = _connector.Books.Find(filters).ToList();

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToJson());
            }
        }

        public static void GetWithFilterClass()
        {
            FilterDefinitionBuilder<Book> builder = Builders<Book>.Filter;

            FilterDefinition<Book> filter =
                builder.Eq(x => x.Author, "George R R Martin") &
                builder.Gte(x => x.Pages, 500) &
                builder.AnyEq(x => x.Subjects, "Action");

            List<Book> books = _connector.Books.Find(filter).ToList();

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToJson());
            }
        }

        public static void GetWithFilterClassAndSort()
        {
            FilterDefinitionBuilder<Book> builder = Builders<Book>.Filter;

            FilterDefinition<Book> filter =
                builder.Eq(x => x.Author, "George R R Martin") &
                builder.Gt(x => x.Pages, 500) &
                builder.AnyEq(x => x.Subjects, "Action");

            List<Book> books = _connector.Books.Find(filter)
                .SortBy(x => x.Title)
                .Limit(5)
                .ToList();

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToJson());
            }
        }

        public static void Update()
        {
            List<Book> books = _connector.Books.Find(new BsonDocument()).ToList();

            Book book = books[0];

            book.Year = 2005;

            _connector.Books.ReplaceOne((x => x.Id == book.Id), book);
        }

        public static void UpdateWithBuilder()
        {
            List<Book> books = _connector.Books.Find(new BsonDocument()).ToList();

            FilterDefinitionBuilder<Book> builderFilter = Builders<Book>.Filter;

            UpdateDefinitionBuilder<Book> builderUpdate = Builders<Book>.Update;

            FilterDefinition<Book> filter = builderFilter.Eq(x => x.Title, "Harry Potter");

            UpdateDefinition<Book> conditional = builderUpdate.Set(x => x.Year, 2021);

            _connector.Books.UpdateOne(filter, conditional);
        }

        public static void Delete()
        {
            List<Book> books = _connector.Books.Find(new BsonDocument()).ToList();

            FilterDefinitionBuilder<Book> builderFilter = Builders<Book>.Filter;

            FilterDefinition<Book> filter = builderFilter.Eq(x => x.Title, "The Lord of the Rings");

            _connector.Books.DeleteOne(filter);
        }
    }
}
