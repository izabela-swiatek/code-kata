using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.UnitTests
{
    internal class TrafficLightsTests
    {
        [TestCase("green", "yellow")]
        [TestCase("yellow", "red")]
        [TestCase("red", "green")]
        public void TrafficLIghts_PreviousLight_ReturnsNextLight(string previousLight, string nextLight)
        {
            Assert.That(TrafficLights.UpdateLight(previousLight), Is.EqualTo(nextLight));
        }
    }
}
