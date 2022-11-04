using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class TwiceAsOldSolutionTests
    {
        [TestCase(30, 0, ExpectedResult = 30)]
        [TestCase(30, 7, ExpectedResult = 16)]
        [TestCase(45, 30, ExpectedResult = 15)]
        public static int TwiceAsOld_GivenAge1Age2_ReturnMissingInt(int dadYears, int sonYears) 
        {
            return TwiceAsOldSolution.TwiceAsOld(dadYears, sonYears);
        }
    }
}


