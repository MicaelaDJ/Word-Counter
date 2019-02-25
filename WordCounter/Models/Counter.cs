using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _word;
    private string _sentence;
    private int _number;
    private static List<Counter> _instances = new List<Counter> {};

    public Counter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      string[] array = _sentence.Split();
      _number = this.FindFunction(_word, array);
      _instances.Add(this);
    }
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

    public static List<Counter> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public int GetNumber()
    {
      return _number;
    }

  }
}
