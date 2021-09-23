using System;

namespace ByteBank_09
{
    public class CheckingAccount
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

            try
            {
                TransactionFee = 30 / TotalAccount;
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                TotalAccount++;
            }
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
