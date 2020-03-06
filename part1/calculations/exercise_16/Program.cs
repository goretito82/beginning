using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
         int time = 86400;

            // input number of days
            Console.Write("How many days?\n");

            //Declare and assign the input as string
            string userInput = Console.ReadLine();

            // Convert string to integer type
           int intValue = Convert.ToInt32(userInput);

           Console.WriteLine(intValue*time);
       
    }
  }
}
