using System;

namespace exercise_47
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int start = 1;
            int number = 0;


            while (true)
            {
                Console.WriteLine("Please where to stop");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please input where to begin");
                int input2 = Convert.ToInt32(Console.ReadLine());


                if (input == 0)
                {
                    break;
                }
                
                while (input2 < input)
                {
                    Console.WriteLine(number + input2 + 1);
                    input2++;
                }


            }


        }
    }
}

