using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            // Write your code here:

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
                // If the input is < 1, add to count
                if (number < 1)
                {
                    // Increase the value of numbers by 1
                    sum += 1;
                }
            }

            // Print the amount of numbers
            Console.WriteLine("Amount of numbers: " + sum);

        }
  }
}
