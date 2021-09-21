using apsys.casino.domain.Shared;
using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    class CardTests
    {
        Card ClassUnderTest { get; set; }

        [SetUp]
        public void SetUp()
        {
            ClassUnderTest = new Card();
            ClassUnderTest.SetMockData();
        }

        [TestCase(CardConstants.Diamonds)]
        [TestCase(CardConstants.Spades)]
        [TestCase(CardConstants.Clubs)]
        [TestCase(CardConstants.Hearts)]
        public void IsValid_ValidSuit_ReturnTrue(string suit)
        {
            // Arrange
            ClassUnderTest.Suit = suit;
            // Act
            bool result = ClassUnderTest.IsValid();
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
            ClassUnderTest.Suit = suit;
            // Act
            bool result = ClassUnderTest.IsValid();
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
            ClassUnderTest.Value = value;
            // Act
            bool result = ClassUnderTest.IsValid();
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
            ClassUnderTest.Value = value;
            // Act
            bool result = ClassUnderTest.IsValid();
            // Assert
            Assert.IsFalse(result);
        }
    }
}
