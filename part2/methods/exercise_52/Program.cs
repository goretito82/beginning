using System;

namespace exercise_52
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Call your method here:

            int number1 = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(number1);


        }

        // Write your method here:
        public static void PrintFromNumberToOne(int numero)
        {
            while (numero-- > 0)
               
            {
                Console.WriteLine(numero);
            }

        }
    }
}