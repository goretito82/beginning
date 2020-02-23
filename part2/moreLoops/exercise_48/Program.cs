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
                    Console.WriteLine("thx Bye!");
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
            Console.WriteLine("Numbers " + totalnum);
            Console.WriteLine("Average " + mean);
            Console.WriteLine("Even " + evennum);
            Console.WriteLine("Odd " + oddnum);


        }
    }
}
