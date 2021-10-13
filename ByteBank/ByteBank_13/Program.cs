using System;
using System.IO;
using System.Text;

namespace ByteBank_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "C:/Users/MiningRig/Desktop/Study/Alura/alura_csharp_course/files/accounts.txt";

            FileStream fs = new(pathFile, FileMode.Open);

            byte[] buffer = new byte[1024];

            int readBytes = fs.Read(buffer, 0, 1024);

            Encoding utf8 = Encoding.UTF8;

            string text = utf8.GetString(buffer, 0, readBytes);

            Console.Write(text);

            Console.ReadLine();
        }
    }
}
