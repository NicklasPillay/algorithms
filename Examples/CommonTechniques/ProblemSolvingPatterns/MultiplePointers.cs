using System;

namespace CommonTechniques.ProblemSolvingPatterns {
  public class MultiplePointers {
    //O(N)
    public static int[] SumZero(int[] arr) {
      int[] result = new int[2];

      int leftIndex = 0;
      int rightIndex = arr.Length - 1;

      do {
        int sum = arr[leftIndex] + arr[rightIndex];
        if (sum == 0) {
          result[0] = arr[leftIndex];
          result[1] = arr[rightIndex];
          return result;
        }
        else if (sum < 0) {
          leftIndex++;
        }
        else {
          rightIndex--;
        }
      }
      while (leftIndex < rightIndex);

      return result;
    }

    //O(N)
    public static int CountUniqueValues(int[] arr) {
      if (arr.Length == 0)
        return 0;

      int index = 0; //serves as counter as well

      for (int j = 1; j < arr.Length; j++) {
        if (arr[index] != arr[j])
          index++;
      }

      return index + 1;
    }
  }
}
