using System;

namespace exercise_50
{
    class Program
    {
        public static void Main(string[] args)
        {

        

            Console.Write(" enter number ");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < number)
            {
                Console.WriteLine();
                i++;

                Printphrase();
            }

        }

        public static void Printphrase()

        {
            Console.WriteLine("In a hole in the ground there lived a method!");
        }

    }

 }


