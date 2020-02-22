using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.Write("Give a number! ");

// Assign new value to userInput
 string userInput = Console.ReadLine();

// Convert string to double type
double doubleValue = Convert.ToDouble(userInput);

Console.WriteLine("You gave " + doubleValue);
    } 
  }
}
