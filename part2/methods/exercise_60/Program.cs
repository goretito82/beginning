using System;

namespace exercise_60
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

        public static void Main(String[] args)
        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            Console.WriteLine("\n");
            PrintSquare(4);
            Console.WriteLine("\n");
            PrintTriangle(5);
            Console.WriteLine("\n");
            PrintRectangle(3, 17);
            
        }

     

        public static void PrintSquare(int size)
        {
            int i, j;
            // number of rows
          for (i = 1; i <= size; i++)
            {
                //number of columns
                for (j = 1; j <= size; j++)
                {
                Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        
        public static void PrintRectangle(int width,int height)
        {
            int i, j;
                 // rows 
            for (i = 1; i <= width; i++)
            {
                // column 
                for (j = 1; j <= height; j++)
                {
                 // print star 
                    Console.Write("*");
                }
                // Move to the next line/row
                Console.WriteLine("");
            }
        }
        public static void PrintTriangle(int size)
        {
            int i, j;
            for (i=1; i<=8; i++)
            {
                for (j=1; j <=i; j++)
                {
                    Console.Write("*");             
                }
                Console.WriteLine();
            }
        }   
    }    
}



