using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class RemoveExclamationTests
    {
        [TestCase("", "")]
        [TestCase("!", "")]
        [TestCase("!!", "")]
        [TestCase("Hi!", "Hi")]
        [TestCase("!?!", "?")]
        public static void RemoveExclamationMarks_TakeString_ReturnStringWithoutExlamation(string previous, string next)
        {
            Assert.That(RemoveExclamation.RemoveExclamationMarks(previous), Is.EqualTo(next));
           
        }
    }
}
