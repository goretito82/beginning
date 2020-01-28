using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
            

            while (true)
            {

                // Ask for integers
                Console.WriteLine("Input an integer, 0 quits");
                // Read user input
                int number = Convert.ToInt32(Console.ReadLine());
                // If the input is 0, exit the loop
                if (number == 0)
                {
                    break;
                }
                //int sum = 0;
                //int counter = 1;

                Console.WriteLine("sum is "  + number);

         


            }
                // Print the amount of 1s from input
                //Console.WriteLine("total sum of numbers: ");
            }
  }
}
