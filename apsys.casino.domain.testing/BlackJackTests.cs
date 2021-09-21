using apsys.casino.domain.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace apsys.casino.domain.testing
{
    class BlackJackTests
    {
        [Test]
        public void BuildDeck_ReturnValidDeck()
        {
            // Arrange
            BlackJack blackJack = new BlackJack();
            // Act
            IEnumerable<Card> deck = blackJack.BuildDeck();
            // Assert
            Assert.NotNull(deck);
            Assert.That(deck.Count(), Is.EqualTo(52));
            foreach (var suitCard in CardConstants.GetAllValidSuits())
            {
                foreach (var cardValue in CardConstants.GetAllValidValues())
                {
                    Assert.That(deck.Count(c => c.Suit == suitCard && c.Value == cardValue), Is.EqualTo(1));
                }
            }
        }
    }
}
