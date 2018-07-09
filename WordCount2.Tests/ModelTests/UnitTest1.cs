using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount2.Controllers;
using WordCount2.Models;
using System;

namespace WordCounter2.Tests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void GetSetUserWord_GetsSetsUserWord_String()
        {
            Item TestCounter = new Item();
            string testWord = "test";
            TestCounter.SetStringOne(testWord);
            Assert.AreEqual(testWord, TestCounter.GetStringOne());
        }

        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_String()
        {
            Item TestCounter = new Item();
            string testWord = "test";
            TestCounter.SetStringTwo(testWord);
            Assert.AreEqual(testWord, TestCounter.GetStringTwo());
        }

        [TestMethod]
        public void GetSetVarX_GetsSetsVarX_Int()
        {
            Item TestCounter = new Item();
            int testInt = 0;
            TestCounter.SetVarX(testInt);
            Assert.AreEqual(testInt, TestCounter.GetVarX());
        }

        [TestMethod]
        public void DigitCheck_CheckCharinStringforDigit_Bool()
        {
            Item TestCounter = new Item();
            string testString = "hello123";
            Assert.AreEqual(false, TestCounter.CorrectInput(testString));
        }

        [TestMethod]
        public void StringCheck_CheckForSpace_Bool()
        {
            Item TestCounter = new Item();
            string testString = "hello dude";
            Assert.AreEqual(false, TestCounter.CorrectInput(testString));
        }

        [TestMethod]
        public void SplitList_String2toSplit_SplitStringArray()
        {
            Item TestCounter = new Item();
            string testPhrase = "this is a test";
            string[] testSplit = { "this", "is", "a", "test" };
            CollectionAssert.AreEqual(testSplit, TestCounter.splitWord(testPhrase));
        }

        [TestMethod]
        public void CompareWithInput_IfForEachArray_CompareSplitString()
        {
            Item TestCounter = new Item();
            string test = "test";
            TestCounter.SetStringOne(test);
            TestCounter.GetStringOne();
            string[] testSplit = { "this", "test", "is", "a", "test" };
            int testInt = 2;
            Assert.AreEqual(testInt, TestCounter.CheckString(testSplit));
        }


    }
}
