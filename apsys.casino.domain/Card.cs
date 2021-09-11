using apsys.casino.domain.Shared;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card
    {
        public string Suit { get; set; }

        public string Value { get; set; }

        public bool IsValid()
            => CardConstats.GetAllValidSuits().Contains(Suit) && CardConstats.GetAllValidValues().Contains(Value);

        public void SetMockData()
        {
            Suit = CardConstats.Diamonds;
            Value = "1";
        }
    }
}
