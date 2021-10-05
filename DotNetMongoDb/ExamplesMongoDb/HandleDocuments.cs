using MongoDB.Bson;
using System;

namespace ExamplesMongoDb
{
    internal class HandleDocuments
    {
        public static void HandleBookDoc()
        {
            BsonDocument doc = new()
            {
                { "Title", "Gerra dos tronos" },
            };

            BsonArray subjects = new();

            subjects.Add("Fantasy");
            subjects.Add("Action");

            doc.Add("Author", "George R R Martin");
            doc.Add("Year", 1999);
            doc.Add("Pages", 856);
            doc.Add("Subjects", subjects);

            Console.WriteLine(doc);
        }
    }
}
