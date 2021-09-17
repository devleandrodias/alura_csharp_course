namespace ByteBank_04
{
    public class CheckingAccount
    {
        public CheckingAccount()
        {
            Balance = 100;
        }

        public string Owner { get; set; }
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
    }
}
