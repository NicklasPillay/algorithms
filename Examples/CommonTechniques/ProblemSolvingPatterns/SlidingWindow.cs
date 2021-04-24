using System;

namespace CommonTechniques.ProblemSolvingPatterns {
  public class SlidingWindow {
    public static int MaxConsecutiveSum(int[] arr, int num) {
      if (arr.Length == 0 || num > arr.Length)
        return 0;

      int maxSum = 0;
      int tempSum = 0;

      for (int i = 0; i < num; i++) {
        tempSum += arr[i]; //first subarray - stored as temp max sum
      }

      if (arr.Length == num) {
        return tempSum; //there is only 1 combination here.
      }

      for (int i = num; i < arr.Length; i++) { //no longer take subset, say 3.
        tempSum = tempSum - arr[i - num] + arr[i]; //now sliding the window and just taking 1.

        if (tempSum > maxSum) {
          maxSum = tempSum;
        }
      }

      return maxSum;
    }
  }
}

