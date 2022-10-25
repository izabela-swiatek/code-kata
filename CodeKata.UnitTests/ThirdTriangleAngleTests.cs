using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class ThirdTriangleAngleTests
    {
        [TestCase(30, 60, 90)]
        [TestCase(60, 60, 60)]
        [TestCase(43, 78, 59)]
        [TestCase(10, 20, 150)]
        [TestCase(180, 0, 0)]
        public void TriangleAngle_TakeTwoAngles_ReturnThird(int a, int b, int c) 
        {
            Assert.That(ThirdTriangleAngle.OtherAngle(a, b), Is.EqualTo(c));
        }
    }
}
