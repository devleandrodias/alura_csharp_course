using System;
using System.IO;

namespace ByteBank_13
{
    internal partial class Program
    {
        private static void BinaryReader(string pathFile)
        {
            using FileStream fs = new(pathFile, FileMode.Open);

            using BinaryReader br = new(fs);

            int agency = br.ReadInt32();
            int number = br.ReadInt32();
            double balance = br.ReadDouble();
            string owner = br.ReadString();

            Console.WriteLine($"{owner} - {balance} - {agency} - {number}");
        }

        private static void BinaryWriter(string pathFile)
        {
            using FileStream fs = new(pathFile, FileMode.Create);

            using BinaryWriter sw = new(fs);

            sw.Write(534);
            sw.Write(47293);
            sw.Write(5323.42);
            sw.Write("Leandro");
        }

        private static void StreamWriterUsingFlush(string pathNewFile)
        {
            using FileStream fs = new(pathNewFile, FileMode.Create);

            using StreamWriter sw = new(fs);

            for (int i = 0; i < 100000; i++)
            {
                sw.WriteLine($"Line - {i}");

                sw.Flush();

                Console.WriteLine($"Line ${i}");
            }
        }
    }
}