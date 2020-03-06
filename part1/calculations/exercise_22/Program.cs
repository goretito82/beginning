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
           double dvalue = Convert.ToDouble(userinput);

            //second integer
            Console.WriteLine("Give the second number!");

            string userinput2 = Console.ReadLine();
            double dvalue2 = Convert.ToDouble(userinput2);

            //third integer
            Console.WriteLine("Give the third number!");
            string userinput3 = Console.ReadLine();
            double dvalue3 = Convert.ToDouble(userinput3);

            //Console.WriteLine(userinput+"+"+userinput2+"+"+userinput3);

            //give answer as a double
            double A = (dvalue+dvalue2+dvalue3) /3;

            Console.WriteLine("The average is " +A);

        }
  }
}
