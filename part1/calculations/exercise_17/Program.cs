using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

          

            Console.Write("Give First integer value: ");

            // Declare and assign the input as string
            string userInput = Console.ReadLine();

            // Convert string to integer type
            int intValue = Convert.ToInt32(userInput);

            Console.WriteLine("First Number " + intValue);

            Console.Write("Give double value: ");

            // Assign new value to userInput
            userInput = Console.ReadLine();

            // Convert string to double type
            double doubleValue = Convert.ToDouble(userInput);

            Console.WriteLine("Second Number " + doubleValue);
            Console.WriteLine(" Your sum is ");
            Console.Write(intValue + doubleValue);

        }
  }
}
