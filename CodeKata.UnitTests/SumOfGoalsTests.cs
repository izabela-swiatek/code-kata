using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class SumOfGoalsTests
    {
        [TestCase(0, 0, 0, 0)]
        [TestCase(42, 4, 12, 58)]
        [TestCase(0, 15, 0, 15)]
        [TestCase(1, 1, 1, 3)]
        public void GetGoals_Given3Numbers_ReturnSum(int laLiga, int copa, int champions, int sum) 
        {
            Assert.That(SumOfGoals.GetGoals(laLiga, copa, champions), Is.EqualTo(sum));
        }
    }
}
