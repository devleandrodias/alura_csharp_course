using System;

namespace ByteBank_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client leandro = new()
            {
                Name = "Leandro",
                Job = "Sr. Backend Software Engineer",
                Cpf = "111.111.111-11"
            };

            CheckingAccount checkingAccountLeandro = new()
            {
                Client = leandro,
                Agency = 145,
                Number = 145673,
                Balance = 5234.34,
            };

            checkingAccountLeandro.Deposit(200);

            checkingAccountLeandro.Withdraw(50);

            checkingAccountLeandro.ShowBalance();

            Console.ReadLine();
        }
    }
}