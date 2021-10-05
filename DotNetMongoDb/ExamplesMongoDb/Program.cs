using MongoDB.Bson;
using System;

namespace ExamplesMongoDb
{
    internal class Program
    {
        static void Main()
        {
            // HandleDocuments.HandleBookDoc();

            // AccessingMongoDb.Execute();

            // BookRepository.Add();

            // HandleExternalClasses.Add();

            // BookRepository.Get();

            // BookRepository.GetWithFilterBson();

            // BookRepository.GetWithFilterClass();

            BookRepository.GetWithFilterClassAndSort();

            Console.WriteLine("Finish...");

            Console.ReadLine();
        }
    }
}
