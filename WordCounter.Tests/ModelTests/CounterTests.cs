using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests : IDisposable
  {

    public void Dispose()
    {
      Counter.ClearAll();
    }
    
    [TestMethod]
    public void InputTest_UserWordIsAString_Bool()
    {
      string testString = "a";
      bool result = false;
      if (testString is string)
      {
        result = true;
      }
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Split_BreakUpSentence_String()
    {
      string testSentence = "apple bear cat dog elephant frog";
      string[] testArray = testSentence.Split();
      Assert.AreEqual("cat", testArray[2]);
    }

    [TestMethod]
    public void SplitFunction_FunctionToBreakUpSentence_String()
    {
      string testSentence = "apple bear cat dog elephant frog";
      Counter counter = new Counter();
      string[] testArray = counter.SplitFunction(testSentence);
      Assert.AreEqual("cat", testArray[2]);
    }

    [TestMethod]
    public void Find_FunctionTestToFindAWordInASentence_Int()
    {
      string testWord = "pizza";
      string testSentence = "My pizza making neighbor made me a pizza";
      string[] testArray = testSentence.Split();
      int result = 0;
      for (int i = 0; i < testArray.Length; i++)
      {
        if (testWord == testArray[i])
        {
          result++;
        }
      }

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void FindFunction_FunctionToFindAWordInASentence_Int()
    {
      string testWord = "pizza";
      string testSentence = "My pizza making neighbor made me a pizza";
      Counter counter = new Counter();
      string[] testArray = testSentence.Split();
      int result = counter.FindFunction(testWord, testArray);
      Assert.AreEqual(2, result);
    }
  }
}
