using AluraOnlineAuction.Core;
using System;

namespace AluraOnlineAuction.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            // Arrange
            Auction auctionVanGogh = new("Van Gogh");

            Interested leandro = new("Leandro", auctionVanGogh);

            Interested thaisa = new("Thaísa", auctionVanGogh);

            auctionVanGogh.StartTradingSession();

            auctionVanGogh.ReceiveBid(leandro, 800);
            auctionVanGogh.ReceiveBid(thaisa, 900);
            auctionVanGogh.ReceiveBid(leandro, 1000);
            auctionVanGogh.ReceiveBid(thaisa, 950);

            // Act
            auctionVanGogh.FinishTradingSession();

            // Assert

            int expectedValue = 1000;
            int obtainedValue = auctionVanGogh.Winner.Value;

            Console.WriteLine($"{auctionVanGogh.Winner.Customer.Name} - {obtainedValue}");
        }
    }
}
