using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            // declare first integer
            Console.WriteLine("Give your percent [0 - 100]:");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);



            if (intvalue < 0)
            {
                Console.WriteLine("Impossible");

            }
            else if (intvalue < 50)
            {
                Console.WriteLine("Fail");
            }

            else if (intvalue >= 50 && intvalue <= 59)

            {
                Console.WriteLine("Grade: 1");
            }

            else if (intvalue >= 60 && intvalue <= 69)
            {
                Console.WriteLine("Grade: 2");

            }
            else if (intvalue >= 70 && intvalue <= 79)
            {
                Console.WriteLine("Grade: 3");

            }
            else if (intvalue >= 80 && intvalue <= 89)
            {
                Console.WriteLine("Grade: 4");

            }
            else if (intvalue >= 90 && intvalue <= 100)
            {
                Console.WriteLine("Grade: 5");

            }
            else if  (intvalue > 100)
            {
                Console.WriteLine("Outstanding!");
            }
        }
  }
}
