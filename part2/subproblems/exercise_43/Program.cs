using System;

namespace exercise_43
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                //input integer convert it
               // Console.WriteLine(" Please put in an integer, 0 exits ");

                int intvalue = Convert.ToInt32(Console.ReadLine());
                //halt prog
                if (intvalue == 0)
                {
                    break;

                }

                if (intvalue < 0)
                {

                    int number = intvalue * -1;

                    Console.WriteLine(number);
                    continue;
                }
                    if (intvalue > 1)
                    {
                        int number2 = intvalue;
                        Console.WriteLine(number2);
                    }

                 
                    


                }
            }
        }
    
}