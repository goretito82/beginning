﻿using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
   Console.WriteLine("Give a number!");

// Declare and assign the input as string
string userInput = Console.ReadLine();

// Convert string to integer type
int intValue = Convert.ToInt32(userInput);

Console.WriteLine("You gave " + intValue);
    }
  }
}