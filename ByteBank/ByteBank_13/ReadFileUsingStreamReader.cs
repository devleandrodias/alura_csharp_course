using System;
using System.IO;
using System.Text;

namespace ByteBank_13
{
    internal partial class Program
    {
        private static void UseStreamReader(string pathFile)
        {
            using FileStream fs = new(pathFile, FileMode.Open);

            using (StreamReader reader = new(fs, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    CheckingAccount acccount = ConvertStringInCheckingAccount(reader.ReadLine());

                    Console.WriteLine(acccount);
                }
            };
        }

        static CheckingAccount ConvertStringInCheckingAccount(string line)
        {
            string[] fields = line.Split(',');

            string agency = fields[0];
            string number = fields[1];
            string balance = fields[2];
            string owner = fields[3];

            return new CheckingAccount(int.Parse(agency), int.Parse(number))
            {
                Balance = double.Parse(balance),
                Client = new Client() { Name = owner },
            };
        }
    }
}