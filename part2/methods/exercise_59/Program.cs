using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(243, 7234, 3243);
      Console.WriteLine("Greatest: " + answer);
    }

        // Write your method here:
        public static int Greatest(int number1, int number2, int number3)
        {
            // write your code here
            int largest = 0;
            if (number1 > number2 && number1 > number3)
                largest = number1;
            else if (number2 > number1 && number2 > number3)
                largest = number2;
            else
                largest = number3;
            return largest;
            
            // do not print anything inside the method

            // there must be a return command at the end
        }

    }
}
