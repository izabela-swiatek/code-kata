using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class FindFirstNonConsecutiveTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 6, 7, 8 }, ExpectedResult = 6)]
        [TestCase(new int[] { -8, -7, -6, -5, -2, -1, 0 }, ExpectedResult = -2)]
        [TestCase(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2 }, ExpectedResult = null)]
        [TestCase(new int[] { -10, -9, -7, -6, -5, -3, -2 }, ExpectedResult = -7)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, ExpectedResult = null)]
        [TestCase(new int[] { 4 }, ExpectedResult = null)]
        [TestCase(new int[] { }, ExpectedResult = null)]

        public static object FirstNonConsecutive_GivenArray_ReturnNonConsecutiveNumber(int[] arrayTested) 
        {
            return FindFirstNonConsecutive.FirstNonConsecutive(arrayTested);
        }
    }
}
