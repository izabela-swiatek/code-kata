using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class VowelsRemovingTests
    {
        [TestCase("This website is for losers LOL!", ExpectedResult = "Ths wbst s fr lsrs LL!")]
        [TestCase("No offense but,\nYour writing is among the worst I've ever read", ExpectedResult = "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")]
        [TestCase("What are you, a communist?", ExpectedResult = "Wht r y,  cmmnst?")]
        public static string Disemvowel_TakeText_ReturnTextWithoutVowels(string vowelString) 
        {
            return VowelsRemoving.Disemvowel(vowelString); 
        }

    }
}
