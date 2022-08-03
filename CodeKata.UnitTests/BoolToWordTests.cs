namespace CodeKata.UnitTests
{
    [TestFixture]
    public class BoolToWordTests
    {
        private static object[] testCases =
        {
            new object[]{ true, "Yes" },
            new object[]{ false, "No" }
        };

        [TestCaseSource("testCases")]
        public void ConvertBoolToWord_PredicateFromTestCaseSource_ReturnsYesForTrueNoForFalse(bool predicate, string expected)
        {
            Assert.AreEqual(expected, BoolToWord.ConvertBoolToWord(predicate));
            Console.WriteLine($"Expected {expected}");
        }

        [TestCase(true, "Yes")]
        [TestCase(false, "No")]
        public void ConvertBoolToWord_PredicateFromTestCase_ReturnsYesForTrueNoForFalse(bool predicate, string expected)
        {
            Assert.AreEqual(expected, BoolToWord.ConvertBoolToWord(predicate));
            Console.WriteLine($"Expected {expected}");
        }

        [Test]
        public void ConvertBoolToWord_True_ReturnsYes()
        {
            Assert.AreEqual("Yes", BoolToWord.ConvertBoolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void ConvertBoolToWord_False_ReturnsNo()
        {
            Assert.AreEqual("No", BoolToWord.ConvertBoolToWord(false));
            Console.WriteLine("Expected No");
        }
    }
}