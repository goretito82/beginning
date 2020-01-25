using System;

namespace exercise_21
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

            Console.WriteLine("Answer is " + userinput + "+" + userinput2);
            
            //give answer as a double
            double A = intvalue + intvalue2 / 2;
            
            Console.WriteLine(A);

           


        }
    }
}
