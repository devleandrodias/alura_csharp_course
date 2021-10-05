using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamplesMongoDb
{
    internal class HandleExternalClasses
    {
        public static async Task Add()
        {
            List<string> subjects = new();

            subjects.Add("Fantasy");
            subjects.Add("Magic");

            Book book = new()
            {
                Title = "The Lord of the Rings",
                Author = "J. R. R. Tolkien",
                Pages = 1211,
                Year = 2002,
                Subjects = subjects
            };

            MongoDbConnector connection = new();

            await connection.Books.InsertOneAsync(book);
        }
    }
}
