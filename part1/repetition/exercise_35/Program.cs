using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                Console.WriteLine("Input a integer, 42 quits");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 42)
                {
                    break;
                }
                if (number >1)
                {
                   Console.WriteLine("Not the desired integer!");
                   continue;
              }

                Console.WriteLine("You gave " + number);
            }

            Console.WriteLine("All done!");

        }
  }
}
