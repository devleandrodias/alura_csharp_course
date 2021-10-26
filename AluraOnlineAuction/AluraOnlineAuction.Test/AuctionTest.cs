using AluraOnlineAuction.Core;
using System;
using Xunit;

namespace AluraOnlineAuction.Test
{
    public class AuctionTest
    {
        [Fact]
        public void AuctionWithMultipleBids()
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
            Assert.Equal(1000, auctionVanGogh.Winner.Value);
        }

        [Fact]
        public void AuctionEithOnlyOneBid()
        {
            // Arrange
            Auction auctionVanGogh = new("Van Gogh");

            Interested leandro = new("Leandro", auctionVanGogh);

            auctionVanGogh.StartTradingSession();

            auctionVanGogh.ReceiveBid(leandro, 800);

            // Act
            auctionVanGogh.FinishTradingSession();

            // Assert
            Assert.Equal(800, auctionVanGogh.Winner.Value);
        }
    }
}
