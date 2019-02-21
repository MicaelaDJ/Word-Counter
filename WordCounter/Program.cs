using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Counter counter = new Counter();
      Console.WriteLine("Write a word");
      string userWord = Console.ReadLine();
      Console.WriteLine("Write a sentence");
      string userSentence = Console.ReadLine();
      string[] sentenceArray = counter.SplitFunction(userSentence);
      int result = counter.FindFunction(userWord, sentenceArray);
      Console.WriteLine("There are " + result + " matches! Hurray...");
    }
  }
}
