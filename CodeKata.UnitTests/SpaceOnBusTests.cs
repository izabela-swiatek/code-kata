using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class SpaceOnBusTests
    {
        [TestCase(10, 5, 5, ExpectedResult = 0)]
        [TestCase(100, 60, 50, ExpectedResult = 10)]
        [TestCase(20, 5, 5, ExpectedResult = 0)]
        public static int Enough_GivenSpaceCount_ReturnLeftPassengersCount(int seats, int passengersIn, int passengersOut) 
        {
            return SpaceOnBus.Enough(seats, passengersIn, passengersOut);
        }

    }
}
