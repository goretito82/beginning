using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give integer value: ");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32 (userInput );
      Console.WriteLine("You gave " + intValue);
      Console.Write("Give integer value: ");  
      userInput  = Console.ReadLine();
      int intValue = Convert.ToInt32 (userInput );
      Console.WriteLine("You gave " + intValue);
    }
  }
}