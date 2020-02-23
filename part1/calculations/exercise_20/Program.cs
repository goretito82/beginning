using System;

namespace exercise_20
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

            Console.WriteLine(userinput + " * " + userinput2);
            
            Console.Write(intvalue * intvalue2);



        }
  }
}
