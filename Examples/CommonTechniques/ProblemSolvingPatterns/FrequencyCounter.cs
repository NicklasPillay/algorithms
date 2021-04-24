using System;
using System.Collections.Generic;

namespace CommonTechniques.ProblemSolvingPatterns {
  public class FrequencyCounter {
    public static bool SameFrequency(int num1, int num2) {
      if (num1.ToString().Length != num2.ToString().Length)
        return false;

      Dictionary<int, int> characterCounter = new Dictionary<int, int>(); //ASCII ID and count

      char[] first = num1.ToString().ToCharArray();
      char[] second = num2.ToString().ToCharArray();

      //Initialize
      for (int i = 48; i < 58; i++) {
        characterCounter.Add(i, 0);
      }

      for (int i = 0; i < first.Length; i++) {
        int asciiValueFirst = (int)first[i];
        int asciiValueSecond = (int)second[i];

        characterCounter[asciiValueFirst]++;
        characterCounter[asciiValueSecond]--;
      }//share same length

      for (int i = 0; i < second.Length; i++) {
        int asciiValue = (int)second[i];

        if (characterCounter[asciiValue] != 0)
          return false;
      }

      return true;
    }

  }
}
