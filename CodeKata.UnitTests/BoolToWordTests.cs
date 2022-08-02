﻿namespace CodeKata.UnitTests
{
    [TestFixture]
    public class BoolToWordTests
    {

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