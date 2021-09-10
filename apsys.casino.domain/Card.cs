using apsys.casino.domain.Shared;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card
    {
        public string Suit { get; set; }

        public string Value { get; set; }

        public bool IsValid()
        {
            string[] validValues = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            if (
                (Suit == SuitConstats.Diamonds || Suit == SuitConstats.Spades || Suit == SuitConstats.Clubs || Suit == SuitConstats.Hearts)
                && (validValues.Contains(Value))
            )
                return true;
            else
                return false;
        }

        public void SetMockData()
        {
            Suit = SuitConstats.Diamonds;
            Value = "1";
        }
    }
}
