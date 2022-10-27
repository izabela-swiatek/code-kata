using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class CharDoubledTests
    {
        [TestCase("abcd", ExpectedResult = "aabbccdd")]
        [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
        [TestCase("1337", ExpectedResult = "11333377")]
        [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
        [TestCase("123456", ExpectedResult = "112233445566")]
        [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
        public static string DoubleChar_String_ReturnCharDoubledString(string s)
        {
            return CharDoubled.DoubleChar(s);
        }
    }
}
