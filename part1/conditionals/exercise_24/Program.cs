using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
            

            //declare integer
            Console.WriteLine("Input integer");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            Console.WriteLine("your speed is " + intvalue);
         

            if (intvalue > 120)
            {
                Console.WriteLine("you are speeding" + intvalue);
            }

        }
  }
}
