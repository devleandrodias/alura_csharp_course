using AluraOnlineAuction.Core;
using System;

namespace AluraOnlineAuction.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Auction auctionVanGogh = new("Van Gogh");

            Interested leandro = new("Leandro", auctionVanGogh);

            Interested thaisa = new("Thaísa", auctionVanGogh);

            auctionVanGogh.StartTradingSession();

            auctionVanGogh.ReceiveBid(leandro, 800);
            auctionVanGogh.ReceiveBid(thaisa, 900);
            auctionVanGogh.ReceiveBid(leandro, 1000);
            auctionVanGogh.ReceiveBid(thaisa, 950);

            auctionVanGogh.FinishTradingSession();

            Console.WriteLine($"{auctionVanGogh.Winner.Customer.Name} - {auctionVanGogh.Winner.Value}");
        }
    }
}
