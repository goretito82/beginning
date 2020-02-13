using System;
using System.Collections.Generic;

namespace exercise_69
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }

            Console.WriteLine("from where");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("To where");
            int number2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count + 1; i++)
            {
                if (i >= number && i <= number2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
