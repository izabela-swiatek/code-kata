namespace CodeKata.UnitTests
{
    [TestFixture]
    public class BoolToWordTests
    {

        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", BoolToWord.ConvertBoolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", BoolToWord.ConvertBoolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", BoolToWord.ConvertBoolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}