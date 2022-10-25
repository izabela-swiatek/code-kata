using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class MonkeyCountArrayTests
    {
        [TestCase(5, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(3, new int[] { 1, 2, 3 })]
        [TestCase(9, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(20, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
        public void MonkeyCount_GivenArrayLenght_ReturnArray(int arrayLength, int[] counted) 
        {
            Assert.That(MonkeyCountArray.MonkeyCount(arrayLength), Is.EqualTo(counted));
        }
    }
}
