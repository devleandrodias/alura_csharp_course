using System;
using System.IO;

namespace ByteBank_13
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "C:/Users/MiningRig/Desktop/Study/Alura/alura_csharp_course/files/accounts.txt";

            using (FileStream fs = new(pathFile, FileMode.Open))
            {
                using (StreamReader reader = new(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                };
            }

            Console.ReadLine();
        }
    }
}
