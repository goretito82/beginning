using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
            //declare integer
            Console.WriteLine("Give your age:");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            if (intvalue<1900)
            {
                Console.WriteLine("You're old");
            }
        }
  }
}
