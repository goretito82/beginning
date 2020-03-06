using System;

namespace exercise_32
{
  class Program
  {
     

        public static void Main(string[] args)
    {

            // declare string
            Console.WriteLine("Speak, friend, and enter!");
            string userinput = Console.ReadLine();
            string a = "Mellon"; 
            if (userinput == a)
            {
                Console.WriteLine("Welcome, friend!");
            }
            else 
            {
                Console.WriteLine("They've got a cave troll!");
            }
     }
  }
}
