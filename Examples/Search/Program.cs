using System;

namespace Search {
  public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("... Searching Types ...");

      //Search Algorithms
      int[] array = { 5, 6, 9, 13, 15, 28, 30 };
      Console.WriteLine(Search.BinarySearch(array, 208));

      //Must be sorted to use Merge Array for Merge 
      int[] sortedArray1 = { 1, 7, 8};
      int[] sortedArray2 = { 1, 6, 7, 12};

      foreach (var item in Search.MergeArrays(sortedArray1, sortedArray2)) {
        Console.Write(item.ToString() + " ");
      }

      int[] array1 = { 12, 6, 17, 13 };
      foreach (var item in Search.MergeSort(array1)) {
        Console.Write(item.ToString() + " ");
      }


      //QUICK SORT 
      //Generic Listing and Swapping
      int[] array2 = { 4, 8, 2, 1, 5, 7, 6, 3 };
      foreach (var item in array2) {
        Console.Write(item.ToString() + " ");
      }

      Console.WriteLine();
      Console.WriteLine();

      Search.GenericSwap(array, 0, 1);
      foreach (var item in array) {
        Console.Write(item.ToString() + " ");
      }

      Console.WriteLine();
      Console.WriteLine();

      Search.GenericSwap(array, 2, 3);
      foreach (var item in array) {
        Console.Write(item.ToString() + " ");
      }

      //Quick Sort tests
      Search.Pivot(array);

      //Radix
      int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };

      // Function Call
      Search.RadixSort(arr);

      foreach (var item in arr) {
        Console.Write(item + " ");
      }

    }
  }
}
