﻿using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
            //declare integer
            Console.WriteLine("Give your age");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            Console.WriteLine("your age is " + intvalue);

            if (intvalue < 1900)
            {
                Console.WriteLine("you're old");
            }
        }
  }
}
