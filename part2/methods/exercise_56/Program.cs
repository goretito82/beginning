using System;

namespace exercise_56
{
  class Program
  {
    public static void Main(String[] args) 
{
  int beginning = 1;
  int end = 5;

  PrintStarts(beginning, end);
}

public static void PrintStars(int beginning, int end) {
  while (beginning < end) {
      Console.Write("*");
      beginning++; // equal to beginning = beginning + 1
  }
}

  }
}
