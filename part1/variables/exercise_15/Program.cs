using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
     Console.WriteLine("Give a string: ");
     Console.ReadLine();
     
     
     Console.Write("Give an integer: ");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);
     Console.WriteLine(" You gave " + intValue);
     
     Console.Write("Give a double: ");
     userInput = Console.ReadLine();
     double doubleValue = Convert.ToDouble(userInput);
     Console.WriteLine(" You gave " + doubleValue);
     
     Console.WriteLine("Give a boolean: ");
      Console.ReadLine();
      string truth = "True";
      bool booleanValue = System.Convert.ToBoolean(truth);
      Console.WriteLine(booleanValue);


    }
  
  }
}
