using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

          

            Console.Write("Give the first number!\n");

            // Declare and assign the input as string
            string userInput = Console.ReadLine();

            // Convert string to integer type
            int intValue = Convert.ToInt32(userInput);

       

            Console.Write("Give the second number!\n");

            // Assign new value to userInput
            userInput = Console.ReadLine();

            
           int intValue2 = Convert.ToInt32(userInput);

            Console.Write("The sum is ");
            Console.WriteLine(intValue + intValue2);
           
        }
  }
}
