using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class SwitchNumberZeroToNineTests
    {
        [TestCase(1, ExpectedResult = "One")]
        [TestCase(3, ExpectedResult = "Three")]
        [TestCase(5, ExpectedResult = "Five")]
        [TestCase(0, ExpectedResult = "Zero")]
        [TestCase(10, ExpectedResult = "Invalid number")]
        public static string SwitchItUp_GivenNumber_ReturnText(int number)
        {
            return SwitchNumberZeroToNine.SwitchItUp(number);
        }
    }

}
