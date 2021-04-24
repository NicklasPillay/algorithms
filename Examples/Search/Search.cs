using System;

namespace Search {
  public class Search {
    public static int BinarySearch(int[] arr, int value) {
      int left = 0;
      int right = arr.Length - 1;
      int middle = (int)Math.Ceiling((right + left) / 2.0);

      do {
        if (arr[middle] == value)
          return middle;
        else if (arr[middle] < value)
          left = middle + 1;
        else
          right = middle - 1;

        middle = (int)Math.Ceiling((right + left) / 2.0);
      }
      while (left <= right);

      return -1;
    }


    /// <summary>
    /// Assumption that arrays are sorted already (Divide and conquer taking place)
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public static int[] MergeArrays(int[] arr1, int[] arr2) {
      if (arr1.Length == 0)
        return arr2;
      if (arr2.Length == 0)
        return arr1;

      int[] resultArr = new int[arr1.Length + arr2.Length];
      int arr1Index = 0;
      int arr2Index = 0;
      int resultIndex = 0;

      do {
        if (arr1[arr1Index] < arr2[arr2Index]) {
          resultArr[resultIndex] = arr1[arr1Index];
          arr1Index++;
        }
        else {
          resultArr[resultIndex] = arr2[arr2Index];
          arr2Index++;
        }

        resultIndex++;

      } while (arr1Index < arr1.Length && arr2Index < arr2.Length);

      while (arr1Index < arr1.Length) {
        resultArr[resultIndex] = arr1[arr1Index];
        arr1Index++;
        resultIndex++;
      }

      while (arr2Index < arr2.Length) {
        resultArr[resultIndex] = arr2[arr2Index];
        arr2Index++;
        resultIndex++;
      }

      return resultArr;
    }


    public static int[] MergeSort(int[] arr) {
      if (arr.Length <= 1)
        return arr;

      int midpointIndex = (int)Math.Floor(arr.Length / 2.00);
      int[] leftArr = new int[midpointIndex];
      int[] rightArr = new int[arr.Length - midpointIndex];

      Array.Copy(arr, 0, leftArr, 0, midpointIndex);
      Array.Copy(arr, midpointIndex, rightArr, 0, rightArr.Length);

      MergeArrays(MergeSort(leftArr), MergeSort(rightArr)); ///Recursion

      return MergeArrays(MergeSort(leftArr), MergeSort(rightArr));
    }


    ////////BEGIN QUICK SORT
    ///
    public static void GenericSwap(int[] arr1, int i, int j) {
      int temp = arr1[i];
      arr1[i] = arr1[j];
      arr1[j] = temp;
    } //swapperoni


    public static int Pivot(int[] arr, int startIndex = 0) {
      int pivotValue = arr[startIndex];
      int swapIndex = startIndex;

      for (int i = startIndex + 1; i < arr.Length; i++) {
        if (arr[i] < pivotValue) {
          swapIndex++;
          GenericSwap(arr, swapIndex, i);
        }
      }

      GenericSwap(arr, startIndex, swapIndex);

      foreach (var item in arr) {
        Console.Write(item.ToString() + " ");
      }

      return swapIndex;
    }

    public static int[] QuickSort(int[] arr, int left = 0, int right = 0) {
      int pivotIndex = Pivot(arr, left);

      if (left < right) {
        //left
        QuickSort(arr, left, pivotIndex - 1);
        //right
        QuickSort(arr, left, pivotIndex + 1);
      }

      return arr;
    }


    //Code from the net, may be helpful to give it a read through
    /*public static int Partition(int[] array, int left, int right) {
      //1. Select a pivot point.
      int pivot = array[right];

      int swapIndex = (left - 1);

      //2. Reorder the collection.
      for (int j = left; j < right; j++) {
        if (array[j] <= pivot) {
          swapIndex++;
          GenericSwap(array, swapIndex, j);
        }
      }

      int temp1 = array[swapIndex + 1];
      array[swapIndex + 1] = array[right];
      array[right] = temp1;

      return swapIndex + 1;
    }

    public static int[] Sort(int[] array, int left, int right) {
      if (left < right) {
        int partitionIndex = Partition(array, left, right);

        //3. Recursively continue sorting the array
        Sort(array, left, partitionIndex - 1);
        Sort(array, partitionIndex + 1, right);
      }

      return array;
    }*/


    //RADIX

    public static int GetMaxNumber(int[] arr) {
      int max = arr[0];
      for (int i = 1; i < arr.Length; i++) {
        if (arr[i] > max)
          max = arr[i];
      }

      return max;
    }


    //From: https://www.geeksforgeeks.org/radix-sort/

    public static int GetMax(int[] arr, int n) {
      int max = arr[0];
      for (int i = 1; i < n; i++) {
        if (arr[i] > max)
          max = arr[i];
      }

      return max;
    }

    // A function to do counting sort of arr[] according to the digit represented by exp.
    public static void CountSort(int[] arr, int exp) {
      int[] output = new int[arr.Length]; // output array
      int[] count = new int[10];

      // initializing all elements of count to 0
      for (int i = 0; i < 10; i++)
        count[i] = 0;

      // Store count of occurrences in count[]
      for (int i = 0; i < arr.Length; i++)
        count[(arr[i] / exp) % 10]++;

      // Change count[i] so that count[i] now contains actual position of this digit in output[]
      for (int i = 1; i < count.Length; i++)
        count[i] += count[i - 1];

      // Build the output array
      for (int i = arr.Length - 1; i >= 0; i--) {
        output[count[(arr[i] / exp) % 10] - 1] = arr[i];
        count[(arr[i] / exp) % 10]--;
      }

      // Copy the output array to arr[], so that arr[] now contains sorted numbers according to current digit
      for (int i = 0; i < arr.Length; i++)
        arr[i] = output[i];
    }

    // The main function to that sorts arr[] of size n using Radix Sort
    public static void RadixSort(int[] arr) {
      int max = GetMax(arr, arr.Length);

      // 10^i where i is current digit number
      for (int exp = 1; max / exp > 0; exp *= 10)
        CountSort(arr, exp);
    }

  }
}
