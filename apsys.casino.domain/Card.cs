using apsys.casino.domain.Shared;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card
    {
        public string Suit { get; set; }

        public string Value { get; set; }

        public bool IsValid()
            => CardConstants.GetAllValidSuits().Contains(Suit) && CardConstants.GetAllValidValues().Contains(Value);

        public void SetMockData()
        {
            Suit = CardConstants.Diamonds;
            Value = "1";
        }
    }
}
