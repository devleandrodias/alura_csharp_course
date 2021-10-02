using ByteBank.Models;
using System;

namespace ByteBank.AgencySystem
{
    internal class Program
    {
        static void Main()
        {
            CheckingAccount checkingAccount = new(0001, 12893);

            Console.WriteLine(checkingAccount.Number);

            Console.ReadLine();
        }
    }
}
