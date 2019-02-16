using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class SameWordClassTest
  {
    [TestMethod]
    public void InputTest_UserWordMatchesSingleLetterSentence_Int()
    {
      SameWordClass testString = new SameWordClass();
      Assert.AreEqual(1, testString.InputTest("a"));
    }

    [TestMethod]
    public void InputTest_UserWordMatchesMultipleLetterSentence_Int()
    {
      SameWordClass testString = new SameWordClass();
      Assert.AreEqual(2, testString.InputTest("a", "a a"))
    }

    [TestMethod]
    public void InputTest_UserWordMatchesMultipleWordSentence_Int()
    {
      SameWordClass testString = new SameWordClass();
      Assert.AreEqual(2, testString.InputTest(userWord, userString));
    }

    [TestMethod]
    public void InputTest_UserWordMatchesLongerMultipleWordSentence_Int()
    {
      SameWordClass testString = new SameWordClass();
      Assert.AreEqual(1, testString.InputTest(userWord, userString));
    }
  }
}
