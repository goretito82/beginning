using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
            
            // declare an int
            Console.WriteLine("Give a number:");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            if (intvalue % 2 == 0)
            {
                Console.WriteLine("It is even.");
            }
            
            else
            
            { 

                Console.WriteLine("It is odd.");
            }



        }
  }
}
