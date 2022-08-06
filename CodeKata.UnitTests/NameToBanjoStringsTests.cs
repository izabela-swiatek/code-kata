using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    public class NameToBanjoStringsTests
    {
        [Test]
        public void AreYouPlayingBanjo_RStartString_ReturnsPlays()
        {
            Assert.AreEqual("Ricardo plays banjo", NameToBanjoStrings.AreYouPlayingBanjo("Ricardo"));
        }

        [Test]
        public void AreYouPlayingBanjo_rStartString_ReturnsPlays()
        {
            Assert.AreEqual("reksin plays banjo", NameToBanjoStrings.AreYouPlayingBanjo("reksin"));
        }

        [Test]
        public void AreYouPlayingBanjo_NoneRStartString_ReturnsNotPlay()
        {
            Assert.AreEqual("Arjuna does not play banjo", NameToBanjoStrings.AreYouPlayingBanjo("Arjuna"));
        }

        [Test]
        public void AreYouPlayingBanjo_NonerStartString_ReturnsNotPlay()
        {
            Assert.AreEqual("melissa does not play banjo", NameToBanjoStrings.AreYouPlayingBanjo("melissa"));
        }

    }
}
