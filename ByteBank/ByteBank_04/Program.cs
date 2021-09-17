using System;

namespace ByteBank_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccountLeandro = new() {
                Owner = "Leandro",
                Balance = 254.23,
                Agency = 234,
                Number = 234534
            };

            CheckingAccount checkingAccountThaisa = new()
            {
                Owner = "Thaísa",
                Balance = 345.45,
                Agency = 234,
                Number = 234864
            };

            Console.WriteLine(checkingAccountLeandro.Balance);

            bool canWithdraw = checkingAccountLeandro.Withdraw(60);

            Console.WriteLine($"Can withdraw? {canWithdraw}");

            Console.WriteLine(checkingAccountLeandro.Balance);

            checkingAccountLeandro.Deposit(45.23);

            checkingAccountLeandro.Deposit(783.34);

            Console.WriteLine(checkingAccountLeandro.Balance);

            checkingAccountThaisa.Transfer(231.34, checkingAccountLeandro);

            Console.WriteLine(checkingAccountLeandro.Balance.ToString("C2"));

            Console.ReadLine();
        }
    }
}
