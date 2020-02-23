using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
            // declare age
           
            Console.WriteLine("How old are you?");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            if (intvalue < 18)
            {
                Console.WriteLine("You're under age!");
            }
            else
            {
                Console.WriteLine("You're an adult!");
            }
        }
  }
}
