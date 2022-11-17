using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class VowelCountingTests
    {
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("you hate when it rains", ExpectedResult = 8)]
        [TestCase("gr8, thx", ExpectedResult = 0)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("woooooow", ExpectedResult = 6)]
        public static int GetVowelCount_TakeText_ReturnVowelNumber(string toBeVowelCounted) 
        {
            return VowelCounting.GetVowelCount(toBeVowelCounted);
        }



    }
}
