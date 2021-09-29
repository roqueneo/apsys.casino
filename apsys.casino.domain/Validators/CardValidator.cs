using apsys.casino.domain.Shared;
using FluentValidation;
using System;
using System.Linq;

namespace apsys.casino.domain.Validators
{
    public class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(x => x.Suit).Must(BeValidSuit);
            RuleFor(x => x.Value).Must(BeValidValue);
        }

        private bool BeValidValue(string value)
        {
            return CardConstants.GetAllValidValues().Contains(value);
        }

        private bool BeValidSuit(string suit)
        {
            return CardConstants.GetAllValidSuits().Contains(suit);
        }
    }
}
