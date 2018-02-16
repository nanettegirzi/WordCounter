using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void RepeatCounter_singlelettertosingeletter_1()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("a", "a");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual("a", countWords);

        }
    }
}
