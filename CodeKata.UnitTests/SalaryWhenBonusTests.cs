using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class SalaryWhenBonusTests
    {
        [TestCase(10000, true, "$100000")]
        [TestCase(25000, true, "$250000")]
        [TestCase(10000, false, "$10000")]
        [TestCase(60000, false, "$60000")]
        [TestCase(2, true, "$20")]
        [TestCase(78, false, "$78")]
        [TestCase(67890, true, "$678900")]
        public void BonusTime_GivenSalaryInt_ReturBonusedSalaryString(int intSalary, bool bonus, string stringSalary) 
        {
            Assert.That(SalaryWhenBonus.BonusTime(intSalary, bonus), Is.EqualTo(stringSalary));
        }
    }
}
