<<<<<<< HEAD
﻿using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {

    }

    public static void PrintStars(int number)
    {

    }

    public static void PrintSpaces(int number)
    {

    }

    public static void PrintRightTriangle(int size)
    {

    }

    public static void ChristmasTree(int height)
    {

    }
  }
}
=======
﻿using System;

namespace exercise_61
{
    class Program
    {

        public static void PrintStars(int number)
        {
            int i = 0;
            while (i < number)
            {
                Console.Write("*");
                i++;
            }
             Console.WriteLine("");
        }
        public static void ChristmasTree(int height)
        {

            for (int n = 1; n < height + 3; n++)
                
             Console.WriteLine(n <= height ?

            new String('*', n * 2 - 1).PadLeft(height + n) :

             "*".PadLeft(height + 2));
            
        }
        public static void Main(String[] args)
        {
            PrintStars(2);
            PrintRightTriangle(4);
            ChristmasTree(10);
            ChristmasTree(4);

        }
        public static void PrintSpaces(int number)
        {
            int i = 0;
            while (i < number)
            {
            Console.Write(" ");
                i++;
            }
            //Console.WriteLine("");
        }
        public static void PrintRightTriangle(int size)

        {
            for (int i=1; i<=size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }

        }
      }
        
    }


>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
