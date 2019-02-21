using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string[] SplitFunction(string sentence)
    {
      string[] arraySentence = sentence.Split();
      return arraySentence;
    }
    public int FindFunction(string word, string[] sentence)
    {
      int result = 0;
      for (int i = 0; i < sentence.Length; i++)
      {
        if (word == sentence[i])
        {
          result++;
        }
      }
      return result;
    }

  }
}
