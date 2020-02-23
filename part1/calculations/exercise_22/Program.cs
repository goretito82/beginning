using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

            //decalre first integer
            Console.WriteLine("Give the first number!");

            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            //second integer
            Console.WriteLine("Give the second number!");

            string userinput2 = Console.ReadLine();
            int intvalue2 = Convert.ToInt32(userinput2);

            //third integer
            Console.WriteLine("Give the third number!");
            string userinput3 = Console.ReadLine();
            int intvalue3 = Convert.ToInt32(userinput3);

            Console.WriteLine(userinput+"+"+userinput2+"+"+userinput3);

            //give answer as a double
            double A = intvalue+intvalue2+intvalue3 /3;

            Console.WriteLine("The average is"+A);

        }
  }
}
