using System;

namespace exercise_51
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Call your method here:

            int number = Convert.ToInt32(Console.ReadLine());
            PrintUntilNumber(number);


        }

        // Write your method here:
        public static void PrintUntilNumber(int numero)
        {
            for (int i = 1; i < numero; i++)
            {
                Console.WriteLine(i);
            }

                    
    }
  }
}
