using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class BeastDishComparisonTests
    {
        [TestCase("great blue heron", "garlic naan", ExpectedResult = true)]
        [TestCase("chickadee", "chocolate cake", ExpectedResult = true)]
        [TestCase("lion", "lemon pudding", ExpectedResult = false)]
        public static bool Feast_GivenTwoStrings_ReturnBool(string beast, string dish)
        {
            return BeastDishComparison.Feast(beast, dish);
        }
    }
}
