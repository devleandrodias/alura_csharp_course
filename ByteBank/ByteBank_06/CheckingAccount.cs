using System;

namespace ByteBank_06
{
    public class CheckingAccount
    {
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

        public int Agency { get; set; }

        public int Number { get; set; }

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
