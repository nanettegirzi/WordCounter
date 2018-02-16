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
        Assert.AreEqual(1, countWords);
        }

        [TestMethod]
        public void RepeatCounter_singlewordtosingeword_1()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("and", "and");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(1, countWords);
        }

        [TestMethod]
        public void RepeatCounter_singlewordtomultiplewordstring_1()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("and", "me and you");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(1, countWords);
        }

        [TestMethod]
        public void RepeatCounter_singlewordtomultiplewordstring_2()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("and", "me and you, and everyone we know");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(2, countWords);
        }

        [TestMethod]
        public void RepeatCounter_uppercaseandlowercase_2()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("and", "me And you, and everyone we know");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(2, countWords);
        }
    }
}
