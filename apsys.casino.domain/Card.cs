using apsys.casino.domain.Shared;
using apsys.casino.domain.Validators;
using FluentValidation.Results;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card : DomainObject, ITesteable
    {
        public string Suit { get; set; }

        public string Value { get; set; }

        public override bool IsValid()
        {
            CardValidator validator = new CardValidator();
            ValidationResult result = validator.Validate(this);
            return result.IsValid;
        }

        public void SetMockData()
        {
            Suit = CardConstants.Diamonds;
            Value = "1";
        }
    }
}
