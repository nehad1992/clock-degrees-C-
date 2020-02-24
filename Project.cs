using System;
using System.Collections.Generic;

class Clock {
  static void Main () {
    // 1 hr is 30 degrees, 1 minute is 0.5 degrees
    Console.WriteLine ("Enter the hour value");
    int hours = int.Parse (Console.ReadLine ());
    int hoursDegree = hours * 30;
    Console.WriteLine ("Enter the minute value");
    int minutes = int.Parse (Console.ReadLine ());
    int minutesDegree = minutes * 6;
    int subtractionValue = Math.Abs ((hoursDegree - minutesDegree));
    if (subtractionValue > 180) {
      int complementValue = 360 - subtractionValue;
      Console.WriteLine (complementValue);
    } else {
      Console.WriteLine (subtractionValue);
    }
  }
}