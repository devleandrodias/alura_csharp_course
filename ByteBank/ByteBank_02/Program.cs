using System;

namespace ByteBank_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccount = new();

            checkingAccount.Owner = "Leandro";

            checkingAccount.Balance = 300;

            Console.WriteLine(checkingAccount.Owner);

            Console.WriteLine(checkingAccount.Balance);

            Console.ReadLine();
        }
    }
}
