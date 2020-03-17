using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
    string text= "true";
     Console.WriteLine("Give a string:");
    string input = Console.ReadLine();
            if (input == text)
            {
            Console.Write("You got it right!");
            }
            else
                {
            Console.Write("Try again!");
            }
    }

  }
}

