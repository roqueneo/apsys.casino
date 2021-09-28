using System;
using System.Linq;

namespace apsys.casino.domain
{
    public class Player : ITesteable
    {
        public string NickName { get; set; }

        public void SetMockData()
        {
            NickName = "pepe";
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(NickName))
                return false;
            string nickName = NickName.Replace(" ", string.Empty);
            if (nickName.Length < 3 || !char.IsLetter(nickName.FirstOrDefault()))
                return false;

            return true;
        }
    }
}
