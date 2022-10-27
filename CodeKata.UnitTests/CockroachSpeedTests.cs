using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class CockroachSpeedTests
    {
        [TestCase(1.08, ExpectedResult = 30)]
        [TestCase(1.09, ExpectedResult = 30)]
        [TestCase(0, ExpectedResult = 0)]
        public static int SpeedCmPerH_SpeedKmPerH_ReturnSpeedCmPerSec(double d)
        {
            return CockroachSpeed.SpeedCmPerH(d);
        }
    }
}
