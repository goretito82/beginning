using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
            //declare number
            Console.WriteLine("Give a number");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            if (intvalue > 0)
            {
                Console.WriteLine("it is positive");
            }
            else
            {
                Console.WriteLine("It is not positive ");
            }
        }
  }
}
