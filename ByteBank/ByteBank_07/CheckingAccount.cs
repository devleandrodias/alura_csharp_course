using System;

namespace ByteBank_07
{
    public class CheckingAccount
    {
        public CheckingAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;

            TotalAccount++;
        }

        public static int TotalAccount { get; private set; }

        private Client _client;

        public Client Client
        {
            get
            {
                return _client;
            }

            set
            {
                _client = value;
            }
        }

        public int Agency { get; private set; }

        public int Number { get; private set; }

        private double _balance = 100;

        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }

        public bool Withdraw(double value)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;

            return true;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Transfer(double value, CheckingAccount accountDestiny)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;

            accountDestiny.Deposit(value);

            return true;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"{_client.Name} - {_balance:C2}");
        }
    }
}
