using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
            // declare first integer
            Console.WriteLine("Give the first number!");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            //declare second int
            // declare first integer
            Console.WriteLine("Give the second number!");
            string userinput2 = Console.ReadLine();
            int intvalue2 = Convert.ToInt32(userinput2);

            if (intvalue > intvalue2)
            {
                Console.WriteLine("The larger number is "+userinput);

            }
            else if (intvalue < intvalue2)
            {
                Console.WriteLine("The larger number is "+userinput2);
            }
            else if (intvalue == intvalue2)
                {
                Console.WriteLine("They are equal!");
            }
    }
  }
}
