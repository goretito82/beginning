using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {


            //decalre first integer
            Console.WriteLine("give first intger");

            string userinput = Console.ReadLine();
            int intvalue = Convert.ToInt32(userinput);

            //second integer
            Console.WriteLine("give second integer");

            string userinput2 = Console.ReadLine();
            int intvalue2 = Convert.ToInt32(userinput2);

            int add;
            int sub;
            int multiply;
            int divide;

             add = intvalue + intvalue2;
             sub = intvalue - intvalue2;
        multiply = intvalue * intvalue2;
        divide   = intvalue / intvalue2;

            //add number
            Console.WriteLine(userinput + "+" + userinput2 + "=" + add);

            // subtract number
            Console.WriteLine(userinput + "-" + userinput2 + "=" + sub);

            // multiply number
            Console.WriteLine(userinput + "*" + userinput2 + "=" + multiply);

            // divide number
            Console.WriteLine(userinput + "/" + userinput2 + "=" + divide);




        }
    }
}
