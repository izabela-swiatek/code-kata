using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class SumArrayWithoutExtremesTests
    {
        [TestCase(new int[] {}, 0)]
        [TestCase(new[] { -6, -2, -1, -8, -10 }, -16)]
        [TestCase(new[] { -16, 2, 100, -86, 10, 14, 0 }, 10)]
        [TestCase(null, 0)]
        [TestCase(new[] { 2 }, 0)]
        [TestCase(new[] { 4, 10 }, 0)]
        [TestCase(new[] { 6, 2, 1, 8, 10 }, 16)]
        [TestCase(new[] { 6, 2, 1, 8, 10, 10 }, 26)]
        [TestCase(new[] { 1, 2, 1, 14, 20, 4, 20 }, 41)]
        public void Sum_TakeArray_ReturnsSumWithoutExtremes(int[] array, int sum)
        {
            Assert.That(SumArrayWithoutExtremes.Sum(array), Is.EqualTo(sum));
        }
    }
}


