namespace AluraOnlineAuction.Core
{
    public class Bid
    {
        public Interested Customer { get; }

        public double Value { get; }

        public Bid(Interested customer, double value)
        {
            Customer = customer;
            Value = value;
        }
    }
}
