using System;

namespace exercise_42
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            while (true)
            {
                //input integer convert it
              
                int intvalue = Convert.ToInt32(Console.ReadLine());
              //input second integer
                int intvalue2 = Convert.ToInt32(Console.ReadLine());


                if (intvalue == 0)
                {
                    break;
                }
                if (intvalue2 == 0)
                {
                    break;
                }

                if (intvalue > 1)
                {
                 int number = intvalue + intvalue2;
                 double squareroot = Math.Sqrt(number);
                Console.WriteLine(squareroot);
                }
            }
        }
    }
}
