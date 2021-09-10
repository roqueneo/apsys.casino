using apsys.casino.domain.Shared;
using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    class CardTests
    {
        [TestCase(SuitConstats.Diamonds)]
        [TestCase(SuitConstats.Spades)]
        [TestCase(SuitConstats.Clubs)]
        [TestCase(SuitConstats.Hearts)]
        public void IsValid_ValidSuit_ReturnTrue(string suit)
        {
            // Arrange
            Card card = new Card();
            card.SetMockData();
            card.Suit = suit;
            // Act
            bool result = card.IsValid();
            // Assert
            Assert.IsTrue(result);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("COINS")]
        [TestCase("1")]
        public void IsValid_InvalidSuit_ReturnFalse(string suit)
        {
            // Arrange
            Card card = new Card();
            card.SetMockData();
            card.Suit = suit;
            // Act
            bool result = card.IsValid();
            // Assert
            Assert.IsFalse(result);
        }

        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        [TestCase("6")]
        [TestCase("7")]
        [TestCase("8")]
        [TestCase("9")]
        [TestCase("10")]
        [TestCase("J")]
        [TestCase("Q")]
        [TestCase("K")]
        public void IsValid_ValidValue_ReturnTrue(string value)
        {
            // Arrange
            Card card = new Card();
            card.SetMockData();
            card.Value = value;
            // Act
            bool result = card.IsValid();
            // Assert 
            Assert.IsTrue(result);           
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        [TestCase("0")]
        [TestCase("j")]
        [TestCase("q")]
        [TestCase("k")]
        [TestCase("-")]
        public void IsValid_InvalidValue_ReturnFalse(string value)
        {
            // Arrange
            Card card = new Card();
            card.SetMockData();
            card.Value = value;
            // Act
            bool result = card.IsValid();
            // Assert
            Assert.IsFalse(result);
        }
    }
}
