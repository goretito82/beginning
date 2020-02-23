using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
            

            //declare integer
            Console.WriteLine("Your speed:");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            Console.WriteLine(intvalue);
         

            if (intvalue > 120)
            {
                Console.WriteLine("Speeding!"+intvalue);
            }

        }
  }
}
