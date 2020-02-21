using System;

namespace exercise_42
{
    class Program
    {
        public static void Main(string[] args)
        {
           // int sum = 0;
          //  int total = 0;

            while (true)
            {
                //input integer convert it
                Console.WriteLine(" Please put in an integer, 0 exits ");

                int intvalue = Convert.ToInt32(Console.ReadLine());

                //input second integer
                Console.WriteLine(" Please put in an integer, 0 exits ");

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
                    Console.WriteLine("the square root of the total sum is " + squareroot);


                }



            }
        }
    }
}
