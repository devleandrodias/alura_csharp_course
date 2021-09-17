using System;

namespace ByteBank_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client= new ()
            {
                Name = "Leandro",
                Cpf = "111.111.111-11",
                Job = "Dev"
            };

            CheckingAccount account = new();

            account.Client = client;

            account.Balance = 10;

            Console.WriteLine(account.Balance);

            account.Deposit(20);

            account.Deposit(15.23);

            account.Withdraw(53.21);

            account.ShowBalance();

            Console.ReadLine();
        }
    }
}
