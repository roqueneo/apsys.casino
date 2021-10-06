using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace apsys.casino.domain.Validators
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.NickName).NotEmpty()
                .MinimumLength(2)
                .MaximumLength(10)
                .Must(BeValidName);
            RuleFor(p => p.Credits).GreaterThanOrEqualTo(0);
        }

        private bool BeValidName(string nickName)
        {
            if (nickName.Contains(" "))
                return false;
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            if (rgx.IsMatch(nickName))
                return true;

            return false; 


        }
    }
}
