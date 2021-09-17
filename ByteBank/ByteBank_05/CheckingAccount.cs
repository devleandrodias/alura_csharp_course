using System;

namespace ByteBank_05
{
    public class CheckingAccount
    {
        public CheckingAccount()
        {
            Balance = 100;
        }

        public Client Client { get; set; }

        public int Agency { get; set; }

        public int Number { get; set; }

        public double Balance { get; set; }

        public bool Withdraw(double value)
        {
            if (Balance < value)
            {
                return false;
            }

            Balance -= value;

            return true;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public bool Transfer(double value, CheckingAccount accountDestiny)
        {
            if (Balance < value)
            {
                return false;
            }

            Balance -= value;

            accountDestiny.Deposit(value);

            return true;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"{Client.Name} - {Balance:C2}");
        }
    }
}
