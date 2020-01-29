using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {
            int start = 0;

            Console.WriteLine("Please input integer");


            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
            for (int i = start; i < input + 1; i++)
                {
                    Console.WriteLine(i);
                }
            
            
            
            
            
            
            }
       


        }
  }
}
