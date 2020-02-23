using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {
            

            // declare first int
            Console.WriteLine("Give the first number!");
            // Declare and assign the input as string
            string userInput = Console.ReadLine();
            // Convert string to integer type
            int intvalue = Convert.ToInt32(userInput);

            

            // declare second int
            Console.WriteLine("Give the second number!");
            // Declare and assign the input as string
            string userInput2 = Console.ReadLine();
            // Convert string to integer type
            int intValue2 = Convert.ToInt32(userInput2);

           Console.WriteLine("The sum is ");
           Console.Write(intvalue + intValue2);

   
           
        }
    }
}
