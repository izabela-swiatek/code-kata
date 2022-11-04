using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class IntFromStringTests
    {
        [TestCase("3 years old", ExpectedResult = 3)]
        [TestCase("4 years old", ExpectedResult = 4)]
        [TestCase("9 years old", ExpectedResult = 9)]
        public static int GetAge_GivenString_ReturnInt(string stringAge) 
        {
            return IntFromString.GetAge(stringAge);
        }

    }
}
