using AluraOnlineAuction.Core;
using System;

namespace AluraOnlineAuction.ConsoleApp
{
    internal class Program
    {
        private static void Verify(double expected, double obtained)
        {
            ConsoleColor color = Console.ForegroundColor;

            if (expected == obtained)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("TEST OK");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"TEST FAIL! \nExpected: {expected}\nObtained: {obtained}");
            }

            Console.ForegroundColor = color;
        }

        private static void AuctionWithMultipleBids()
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
            Verify(1000, auctionVanGogh.Winner.Value);
        }

        private static void AuctionEithOnlyOneBid()
        {
            // Arrange
            Auction auctionVanGogh = new("Van Gogh");

            Interested leandro = new("Leandro", auctionVanGogh);

            auctionVanGogh.StartTradingSession();

            auctionVanGogh.ReceiveBid(leandro, 800);

            // Act
            auctionVanGogh.FinishTradingSession();

            // Assert
            Verify(800, auctionVanGogh.Winner.Value);
        }

        static void Main()
        {
            AuctionWithMultipleBids();

            AuctionEithOnlyOneBid();

            Console.ReadLine();
        }
    }
}
