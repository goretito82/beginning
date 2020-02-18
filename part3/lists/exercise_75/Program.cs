using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_75
{
  class Program
  {
   public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)

   {
   foreach (int number in numbers.Where (number => number >= lowerLimit && number <= upperLimit))
    {
    Console.WriteLine(number);
    }
   }
            public static void Main(string[] args)
   {
                // Example method calls for testing your method.
          List<int> numbers = new List<int>();
          numbers.Add(3);
          numbers.Add(2);
          numbers.Add(6);
          numbers.Add(-1);
          numbers.Add(5);
          numbers.Add(1);

    Console.WriteLine("The numbers in the range [0, 5]");
    PrintNumbersInRange(numbers, 0, 5);
    }
    }
  }
    