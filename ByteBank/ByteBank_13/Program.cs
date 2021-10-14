using System;
using System.IO;

namespace ByteBank_13
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "C:/Users/MiningRig/Desktop/Study/Alura/alura_csharp_course/files/accounts.txt";

            string pathNewFile = "C:/Users/MiningRig/Desktop/Study/Alura/alura_csharp_course/files/binary.txt";

            string[] lines = File.ReadAllLines(pathFile);

            Console.WriteLine(lines.Length);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
