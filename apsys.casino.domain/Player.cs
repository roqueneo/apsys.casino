using System;

namespace apsys.casino.domain
{
    public class Player
    {
        public string NickName { get; set; }

        public void SetMockData()
        {
            NickName = "pepe";
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(NickName) || NickName.Trim().Length < 3)
                return false;

            return true;
        }
    }
}
