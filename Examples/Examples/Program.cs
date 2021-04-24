using System;

namespace Recursion {
  public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("... Recursion ...");
      Console.WriteLine(Recursion.Power(5, 1));
      Console.WriteLine(Recursion.Factorial(7));

      int[] array = { 2, 5, 10, 2 };

      Console.WriteLine(Recursion.ProductOfArray(array));

      Console.WriteLine(Recursion.RecursiveRange(10));

      Console.WriteLine(Recursion.Fibonacci(28));
    }
  }
}
