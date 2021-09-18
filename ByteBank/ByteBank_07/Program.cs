using System;

namespace ByteBank_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount accountLeandro = new(0001, 246463);

            CheckingAccount accountThaisa = new(0001, 849235);

            CheckingAccount accountBia = new(0001, 826378);

            Console.WriteLine("Total accounts: {0}", CheckingAccount.TotalAccount);

            Console.ReadLine();
        }
    }
}
