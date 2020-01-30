using System;

namespace exercise_48
{
    class Program
    {
        public static void Main(string[] args)
        {
            //declare number
            Console.Write("Give numbers: ");

            //variables
            int sum = 0;
            int totalnum = 0;
            int mean = 0;
            int evennum = 0;
            int oddnum = 0;


            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {
                    Console.WriteLine("thnk bye!");
                    break;
                }

                if (input % 2 == 0)
                {
                    evennum++;
                    continue;
                }

                else _ = (input);
                oddnum++;
             

            
                sum += input;
                totalnum++;
                mean = sum / totalnum;

               
            }

            
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("total numbers " + totalnum);
            Console.WriteLine("mean average " + mean);
            Console.WriteLine("even number " + evennum);
            Console.WriteLine("odd number " + oddnum);


        }
    }
}
