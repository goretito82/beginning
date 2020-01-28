using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

            while (true)
            {
                //input integer convert it
                Console.WriteLine(" Please put in frst integer, 0 exits ");
                int intvalue = Convert.ToInt32(Console.ReadLine());

                //input 2nd integer
                Console.WriteLine(" Please put in second integer, 0 exits ");
                int intvalue2 = Convert.ToInt32(Console.ReadLine());


                //halt prog
                if (intvalue == 0)
                {
                    break;

                }

                if (intvalue > intvalue2)
                {

                Console.WriteLine( intvalue + " is greater than " + intvalue2 );
                    continue;
                }
                if (intvalue < intvalue2)
                {
                   
                    Console.WriteLine(intvalue + " is lesser than " + intvalue2);
                    continue;
                }

                if (intvalue == intvalue2)
                {

                    Console.WriteLine(intvalue + " is equal to " + intvalue2);
                    continue;
                }



            }


        }
  }
}
