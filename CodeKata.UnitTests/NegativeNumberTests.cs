using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    public class NegativeNumberTests
    {
        [Test]
        public void MakeNegative_Positive_ReturnsNegative()
        {
            Assert.AreEqual(-42, NegativeNumber.MakeNegative(42));
        }
    }
}
