using System;

namespace Recursion {
  public class Recursion {
    public static int Power(int baseNumber, int exponent) {
      if (exponent == 0)
        return 1;
      else
        return baseNumber * Power(baseNumber, exponent - 1);
    }

    public static int Factorial(int number) {
      if (number == 0)
        return 1;
      else
        return number * Factorial(number - 1);
    }

    public static int ProductOfArray(int[] numbers, int index = 0) {
      if (index == numbers.Length)
        return 1;

      return numbers[index] * ProductOfArray(numbers, index + 1);
    }// try doing this without an index parameter;

    public static int RecursiveRange(int num) {
      if (num == 0)
        return 0;

      return num + RecursiveRange(num - 1);
    }

    public static int Fibonacci(int nth, int num1 = 1, int num2 = 1) {
      if (nth == 1)
        return num1;

      return Fibonacci(nth - 1, num2, num1 + num2);
    }
  }
}


/*
 * Power(2,4)
 *    Power(2, 3)
 *        Power (2, 2)
 *            Power (2, 1)
 *                total
 * 
* Power(2,4)
 *    Power(2, 3)
 *        Power (2, 2)
 *            Power (2, 1)
 *                total
 * 
 * 
 * 1 1 2 3 5 8 
 * 
 */
