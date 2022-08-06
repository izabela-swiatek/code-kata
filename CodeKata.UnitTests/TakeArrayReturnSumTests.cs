using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    [TestFixture]
    public class TakeArrayReturnSumTests
    {
        private static object[] testCases = new object[]
        {
            new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
            new object[] {new double[] {}, 0},
        };

        [Test, TestCaseSource("testCases")]
        public void Test(double[] array, double expected) => Assert.AreEqual(expected, TakeArrayReturnSum.SumArray(array));
    }
}
