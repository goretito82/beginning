using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            // declare first integer
            Console.WriteLine("Give your percentage");
            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);



            if (intvalue == 0)
            {
                Console.WriteLine("impossible " + userinput);

            }
            else if (intvalue < 50)
            {
                Console.WriteLine("Fail " + userinput);
            }

            else if (intvalue >= 50 && intvalue <= 59)

            {
                Console.WriteLine("Grade 1 " + userinput);
            }

            else if (intvalue >= 60 && intvalue <= 69)
            {
                Console.WriteLine("Grade 2 " + userinput);

            }
            else if (intvalue >= 70 && intvalue <= 79)
            {
                Console.WriteLine("Grade 3 " + userinput);

            }
            else if (intvalue >= 80 && intvalue <= 89)
            {
                Console.WriteLine("Grade 4 " + userinput);

            }
            else if (intvalue >= 90 && intvalue <= 100)
            {
                Console.WriteLine("Grade 5 " + userinput);

            }
            else if  (intvalue > 100)
            {
                Console.WriteLine("Outstanding! " + userinput);
            }
        }
  }
}
