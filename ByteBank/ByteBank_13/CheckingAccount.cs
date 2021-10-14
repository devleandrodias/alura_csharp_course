using ByteBank_13.Exceptions;
using System;

namespace ByteBank_13
{
    public class CheckingAccount : IComparable
    {
        public static double TransactionFee { get; private set; }

        public CheckingAccount(int agency, int number)
        {
            if (agency <= 0)
            {
                throw new ArgumentException("Argument agency must be greater than zero.", nameof(agency));
            }

            if (number <= 0)
            {
                throw new ArgumentException("Argument number must be greater than zero.", nameof(number));
            }

            Agency = agency;

            Number = number;

            TotalAccount++;

            TransactionFee = 30 / TotalAccount;
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

        public int Agency { get; }

        public int Number { get; }

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

        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value for withdrawal.", nameof(value));
            }

            if (_balance < value)
            {
                throw new InsufficientFundsException(Balance, value);
            }

            _balance -= value;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public void Transfer(double value, CheckingAccount accountDestiny)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value for transfer.", nameof(value));
            }

            Withdraw(value);

            accountDestiny.Deposit(value);
        }

        public void ShowBalance()
        {
            Console.WriteLine($"{_client.Name} - {_balance:C2}");
        }

        public override string ToString()
        {
            return $"Balance: {Balance} - Number account: {Number} - Agency number: {Agency} - Owner: {Client.Name}";
        }

        public int CompareTo(object obj)
        {
            if (obj is not CheckingAccount account) { return -1; }

            if (Number < account.Number) { return -1; }

            if (Number == account.Number) { return 0; }

            return 1;
        }
    }
}
