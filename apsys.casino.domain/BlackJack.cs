using apsys.casino.domain.Shared;
using System.Collections.Generic;

namespace apsys.casino.domain
{
    public class BlackJack
    {
        public IEnumerable<Card> BuildDeck()
        {
            IList<Card> cards = new List<Card>();
            foreach (var cardSuit in CardConstants.GetAllValidSuits())
            {
                foreach (var cardValue in CardConstants.GetAllValidValues())
                    cards.Add(new Card { Suit = cardSuit, Value = cardValue });
            }
            return cards;
        }
    }
}
