using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
            
            int number = 0;
            int input = Convert.ToInt32(Console.ReadLine());

            while (input < 100)
            {
             Console.WriteLine(number + input +1);
             input++;

            }

        }
    }
}
