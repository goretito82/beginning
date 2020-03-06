using System;

namespace exercise_23
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

            double add;
            double sub;
            double multiply;
            double divide;

             add = dvalue + dvalue2;
             sub = dvalue - dvalue2;
        multiply = dvalue * dvalue2;
        divide   = dvalue / dvalue2;

            //add number
            Console.WriteLine(userinput + " + " + userinput2 + " = " + add);

            // subtract number
            Console.WriteLine(userinput + " - " + userinput2 + " = " + sub);

            // multiply number
            Console.WriteLine(userinput + " * " + userinput2 + " = " + multiply);

            // divide number
            Console.WriteLine(userinput + " / " + userinput2 + " = " + divide);




        }
    }
}
