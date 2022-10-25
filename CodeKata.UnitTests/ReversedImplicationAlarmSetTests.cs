using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class ReversedImplicationAlarmSetTests
    {
        [TestCase(true, true, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, false)]
        [TestCase(true, false, true)]
        public void SetAlarm_WhenConditions_ReturnBool(bool firstCondition, bool secondCondition, bool result) 
        {
            Assert.That(ReversedImplicationAlarmSet.SetAlarm(firstCondition, secondCondition), Is.EqualTo(result));
        }
    }
}
