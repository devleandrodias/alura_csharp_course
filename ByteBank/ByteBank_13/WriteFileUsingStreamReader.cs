using System;
using System.IO;
using System.Text;

namespace ByteBank_13
{
    internal partial class Program
    {
        private static void CreateFileWithBytes(string pathNewFile)
        {
            using FileStream fs = new(pathNewFile, FileMode.Create);

            string account = "384,283045,6423.34,Gustavo Santos";

            Encoding enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(account);

            fs.Write(bytes, 0, bytes.Length);
        }

        private static void CreateFileWithWriter(string pathNewFile)
        {
            using (FileStream fs = new(pathNewFile, FileMode.CreateNew))

            using (StreamWriter sw = new(fs, Encoding.UTF8))
            {
                sw.Write("642,54363,12235.34,Lucas");
            };

            Console.WriteLine("Accounts exported...");
        }
    }
}