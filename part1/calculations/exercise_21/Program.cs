using System;

namespace exercise_21
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

           // Console.WriteLine( userinput + "+" + userinput2);
            
            //give answer as a double
            double A = (dvalue + dvalue2)   / 2;
            
            Console.WriteLine("The average is "+ A);

           


        }
    }
}
