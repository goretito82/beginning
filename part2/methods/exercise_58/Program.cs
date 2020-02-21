using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(889, 4367);
      Console.WriteLine("Smallest: " + answer);
    }

        // Write your method here:
        public static int Smallest(int number1, int number2)
        {
            // write your code here
            

            return Math.Min(number1, number2);

        
            
            // do not print anything inside the method

            // there must be a return command at the end
        }
    }
}
