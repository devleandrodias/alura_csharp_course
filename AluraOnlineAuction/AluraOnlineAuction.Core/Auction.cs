using System.Collections.Generic;
using System.Linq;

namespace AluraOnlineAuction.Core
{
    public class Auction
    {
        private readonly IList<Bid> _bids;

        public IEnumerable<Bid> Bids => _bids;

        public string Thing { get; }

        public Bid Winner { get; private set; }

        public Auction(string thing)
        {
            Thing = thing;
            _bids = new List<Bid>();
        }

        public void ReceiveBid(Interested customer, double value)
        {
            _bids.Add(new Bid(customer, value));
        }

        public void StartTradingSession()
        {

        }

        public void FinishTradingSession()
        {
            Winner = _bids.Last();
        }
    }
}
