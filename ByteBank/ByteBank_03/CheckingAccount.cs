namespace ByteBank_03
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
    }
}
