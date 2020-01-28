using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                Console.WriteLine("Input a positive integer, 0 quits");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number < 0)
                {
                    Console.WriteLine("that is negative!");
                    continue;
                }

                Console.WriteLine("You gave " + number * 2);
            }

            Console.WriteLine("All done!");

        }
  }
}
