using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
            
            //declare integer
            Console.WriteLine("Give a number:");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            if (intvalue==1984)
            {
                Console.WriteLine("Orwell");
            }
        }

    }
}
