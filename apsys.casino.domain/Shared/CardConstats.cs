using System;
using System.Collections.Generic;
using System.Text;

namespace apsys.casino.domain.Shared
{
    public static class CardConstats
    {
        // Suit contansts
        public const string Diamonds = "DIAMONDS";
        public const string Spades = "SPADES";
        public const string Clubs = "CLUBS";
        public const string Hearts = "HEARTS";

        public static string[] GetAllValidSuits() 
        {
            return new string[] { Diamonds, Spades, Clubs, Hearts };
        }

        // Value constants
        public const string V01 = "1";
        public const string V02 = "2";
        public const string V03 = "3";
        public const string V04 = "4";
        public const string V05 = "5";
        public const string V06 = "6";
        public const string V07 = "7";
        public const string V08 = "8";
        public const string V09 = "9";
        public const string V10 = "10";
        public const string VJ = "J";
        public const string VQ = "Q";
        public const string VK = "K";

        public static string[] GetAllValidValues()
        {
            return new string[] { V01, V02, V03, V04, V05, V06, V07, V08, V09, V10, VJ, VQ, VK };
        }
    }
}
