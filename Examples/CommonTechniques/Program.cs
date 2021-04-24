using System;
using CommonTechniques.ProblemSolvingPatterns;

namespace CommonTechniques {
  public class Program {
    public static void Main(string[] args) {
      //udemy.com/course/js-algorithms-and-data-structures-masterclass
      //Anagrams
      if (Anagrams.IsAnagrams4("cola !!", "coal! ! "))
        Console.WriteLine("True");
      else
        Console.WriteLine("False");


      //Multiple Pointers
      int[] sortedArr = { -7, -3, -2, -2, 1, 2, 8, 9, 10, 11, 22, 22, 22, 22 };
      foreach (var item in MultiplePointers.SumZero(sortedArr)) {
        Console.WriteLine(item.ToString());
      }

      Console.WriteLine(MultiplePointers.CountUniqueValues(sortedArr));


      //Sliding Window
      int[] arr = { 2, 6, 9, 10, 10, 8, 5, 6, 3 };
      int span = 3;

      Console.WriteLine(SlidingWindow.MaxConsecutiveSum(arr, span));


      //Section 6 - Exercise 3

      //(182, 281) //true
      //(34, 14) //false 
      //(3589578, 5879385) //true
      //(22, 222) //false

      if (FrequencyCounter.SameFrequency(182, 281))
        Console.WriteLine("True");
      else
        Console.WriteLine("False");

    }
  }
}
