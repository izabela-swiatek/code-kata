using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class NumberDigitsSquaringTests
    {
        [TestCase(9119, ExpectedResult = 811181)]
        [TestCase(0, ExpectedResult = 0)]
        public static int SquareDigits_GivenNumber_ReturnSquaredDigitsNumber(int number) 
        {
            return NumberDigitsSquaring.SquareDigits(number);
        }
    }
}
