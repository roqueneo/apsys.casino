using apsys.casino.domain.Validators;
using FluentValidation.Results;
using System.Linq;

namespace apsys.casino.domain
{
    public class Player : DomainObject, ITesteable
    {
        public string NickName { get; set; }

        public int Credits { get; set; }

        public void SetMockData()
        {
            NickName = "pepe";
            Credits = 10;
        }

        public override bool IsValid()
        {
            PlayerValidator validator = new PlayerValidator();
            ValidationResult validationResult = validator.Validate(this);
            return validationResult.IsValid; 
            //if (string.IsNullOrWhiteSpace(NickName))
            //    return false;
            //string nickName = NickName.Replace(" ", string.Empty);
            //if (nickName.Length < 3 || !char.IsLetter(nickName.FirstOrDefault()))
            //    return false;

            //return true;
        }
    }
}
