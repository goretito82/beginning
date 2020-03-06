using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("That is negative");
                    
                }
               else if (number == 0)
                {
                    break;
                }
                else
                {

               Console.WriteLine(number * 2);
            }
      }
   }
  }
  }
