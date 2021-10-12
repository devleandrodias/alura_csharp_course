using System;

namespace ByteBank_12.Exceptions
{
    internal class InsufficientFundsException : Exception
    {
        public double Balance { get; }

        public double WithdrawalAmount { get; }

        public InsufficientFundsException()
        {

        }

        public InsufficientFundsException(double balance, double withdrawalAmount) :
            this($"Attempt to withdraw {withdrawalAmount} from an account with a balance of {balance}")
        {
            Balance = balance;

            WithdrawalAmount = withdrawalAmount;
        }

        public InsufficientFundsException(string message) : base(message)
        {

        }
    }
}
