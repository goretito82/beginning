using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

            // Write your code here:
            Console.Write("Give the first number!\n");

            // Declare and assign the input as string
            string userInput = Console.ReadLine();

            // Convert string to integer type
            int intValue = Convert.ToInt32(userInput);

          

            Console.Write("Give the second number!\n");

            // Assign new value to userInput
            userInput = Console.ReadLine();

            // Convert string to double type
            double doubleValue = Convert.ToDouble(userInput);

         

            Console.Write("Give the third number!\n");

            // Declare and assign the input as string
            string userInput1 = Console.ReadLine();

            // Convert string to integer type
            int intValue1 = Convert.ToInt32(userInput1);

           // Console.WriteLine("You gave " + intValue1);

            //add the three integers
            Console.WriteLine("The sum is");
            Console.Write(intValue + doubleValue + intValue1);

        }
  }
}
