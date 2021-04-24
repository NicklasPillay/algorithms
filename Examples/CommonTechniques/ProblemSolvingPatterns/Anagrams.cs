using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTechniques.ProblemSolvingPatterns {
  public class Anagrams {
    /// <summary>
    /// Check word 1 and 2 contains same letters only
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public static bool ValidAnagram(string str1, string str2) {
      if (str1.Length != str2.Length)
        return false;

      Dictionary<string, int> dictionary1 = GetCharacterCount(str1);
      Dictionary<string, int> dictionary2 = GetCharacterCount(str2);

      dictionary1.Except(dictionary2);

      return dictionary1.Count == dictionary2.Count && !dictionary1.Except(dictionary2).Any();
    }

    public static Dictionary<string, int> GetCharacterCount(string str) {
      string processedInput = str.ToLower();
      Dictionary<string, int> myDictionary = new Dictionary<string, int>();

      foreach (char c in processedInput) {
        if (myDictionary.ContainsKey(c.ToString()))
          myDictionary[c.ToString()] = myDictionary[c.ToString()] + 1;
        else
          myDictionary.Add(c.ToString(), 1);
      }

      Console.WriteLine("Original String: {0}", str);

      foreach (var item in myDictionary) {
        Console.WriteLine(item);
      }

      Console.WriteLine();
      return myDictionary;
    }

    /// <summary>
    /// Checks if a entire string (sentence even) can be an anagram 
    /// </summary>
    /// <param name="stringOne"></param>
    /// <param name="stringTwo"></param>
    /// <returns></returns>
    public static bool IsAnagrams4(string stringOne, string stringTwo) {
      if (stringOne.Length != stringTwo.Length)
        return false;

      char[] first = stringOne.ToLower().ToCharArray();
      char[] second = stringTwo.ToLower().ToCharArray();
      Dictionary<char, int> characterCount = new Dictionary<char, int>(); //ASCII

      for (int i = 0; i < 256; i++) {
        //could add an if statement here to check if Letter or Digit, and then only add.
        characterCount.Add((char)i, 0); //Initialize ASCII Dictionary
      }

      for (int i = 0; i < first.Length; i++) {
        characterCount[first[i]]++;
        characterCount[second[i]]--;
      }

      foreach (var item in characterCount) {
        if (item.Value != 0)
          return false;
      }

      return true;
    }

  }
}
